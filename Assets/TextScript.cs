using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Tsk tsk";   
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Objects on screen: " + Singleton.objectsOnScreen.ToString();
    }
}
