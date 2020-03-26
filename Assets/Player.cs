using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private int points;
    [SerializeField] private bool hasMessageBeenSent;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            points += 10;
            //points = points + 10;

        }

        if (points >= 50 && hasMessageBeenSent == false)
        {
            Debug.Log("You are the best!");
            hasMessageBeenSent = true;
        }
    }
}
