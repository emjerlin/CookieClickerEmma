using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    // Start is called before the first frame update

    int score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        print(score);


   

    }
    private int OnMouseUp()
    {


        score++;
        return score;
    }
}
