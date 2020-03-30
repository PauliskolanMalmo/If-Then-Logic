using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeedProgram : MonoBehaviour
{
    public int speed = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            speed += 5;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            speed -= 5;
        }

        if (speed > 20)
        {
            print("Slow down");
        }
        else if (speed == 0)
        {
            print("Speed up");
        }

        if (speed < 0)
        {
            speed = 0;
        }
    }
}
