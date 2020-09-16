using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float speed = 0.5f;
    public Vector2 start;

    // Start is called before the first frame update
    void Start()
    {
        start = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale = new Vector3(8.0f * Mathf.Cos(Time.time), 8.0f * Mathf.Sin(Time.time), 1);

        Vector2 offset = new Vector2(0, Time.time * speed);

        // Move the sprite across the screen:
        gameObject.transform.position = new Vector2(Singleton.x, start.y);
    }
}
