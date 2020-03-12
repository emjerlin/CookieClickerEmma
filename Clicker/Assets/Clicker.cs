using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int end = 0;

        int click = 0;

        while (end == 0) { 
        OnMouseUp();
        }


        int OnMouseUp()
        {
            click++;

            return click;
        }

    }
}
