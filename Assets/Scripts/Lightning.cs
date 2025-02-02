using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    // Boolean variable to determine whether or not the lightning is currently present
    bool struck = false;

    void Start()
    { 

    }

    void Update()
    {
        // Creates vector for lightning scale
        Vector2 size = transform.localScale;


        // Space bar makes lightning appear and disappear
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Determines whether the lightning appears or disappears
            if (struck == false)
            {
                size.x = 0.57f;
                size.y = 2.3f;
                struck = true;  
            }
            else
            {
                size.x = 0;
                size.y = 0;
                struck = false;
            }
        }

        // Updates the lightning's position
        transform.localScale = size;
    }
}
