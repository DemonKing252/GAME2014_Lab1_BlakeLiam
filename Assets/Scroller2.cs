using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller2 : MonoBehaviour
{
    Vector2 screenBounds;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        pos = new Vector3(0, 0, 0);
        Debug.Log("New Object Created!");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x >= screenBounds.x)
        {
            Destroy(this.gameObject);
            Singleton.objectsOnScreen--;
        }
        else
        {
            pos.x += Time.deltaTime;
     
            gameObject.transform.position = new Vector3(pos.x, 0, 0);
     
        }    
    }
}
