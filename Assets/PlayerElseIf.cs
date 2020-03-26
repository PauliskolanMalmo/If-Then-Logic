using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerElseIf : MonoBehaviour
{
    public float q1, q2, q3, q4, q5;
    public float average;

    void Start()
    {


        /*
        q1 = Random.Range(0f, 100f);
        q2 = Random.Range(0f, 100f);
        q3 = Random.Range(0f, 100f);
        q4 = Random.Range(0f, 100f);
        q5 = Random.Range(0f, 100f);
        */

        average = (q1 + q2 + q3 + q4 + q5) / 5;

        if (average >= 90)
        {
            print("");
            print("A");
        }
        else if (average >= 80 && average < 90)
        {
            print("B");
        }
        else if (average >= 70 && average < 80)
        {
            print("C");
        }
        else
        {
            print("F");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
