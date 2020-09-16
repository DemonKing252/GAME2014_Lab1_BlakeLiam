using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float nextSpawn;
    public GameObject rock;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
        nextSpawn += Time.deltaTime;

        if (gameObject == null)
            Debug.Log("Object is null!");
        
        if (nextSpawn >= 1.0f)
        {
            Singleton.objectsOnScreen++;

            nextSpawn = 0.0f;

            Vector3 trans = new Vector3(0, 0, 0);
            
            Instantiate(rock, trans, Quaternion.identity);


            Singleton.x = Time.time;
        }

        
    }
}
