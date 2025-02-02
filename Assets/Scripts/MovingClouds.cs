using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MovingClouds : MonoBehaviour
{
    // Allows access to the animation curve and starting and ending points for clouds
    public AnimationCurve curve;

    [Range(0, 4)]
    public float t;

    public Transform start;
    public Transform end;

    void Start()
    {
        
    }

    // 
    void Update()
    {
        // Evens out fps, counts for 4 seconds at the end of the animation
        t += Time.deltaTime;

        if (t > 4)
        {
            t = 0;
        }

        // Slides the clouds along the animation curve
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));

    }
}
