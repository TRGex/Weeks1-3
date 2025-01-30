using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrickShot : MonoBehaviour
{
    public AnimationCurve curve;

    float speed = 10f;
    float t = 0;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        //Makes the ball jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //transform.localScale = Vector2 * curve.Evaluate(t);
        }

        //This determines the size of the screen
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 screenSizeInTheWorld = new Vector2();
        screenSizeInTheWorld = Camera.main.ScreenToWorldPoint(screenSize);

        //This makes the shape bounce back when hitting a wall
        Vector2 screenZeroInTheWorld = Camera.main.ScreenToWorldPoint(Vector2.zero);

        if (pos.x < screenZeroInTheWorld.x || pos.x > screenSizeInTheWorld.x)
        {
            speed *= -1;
        }

        transform.position = pos;
    }
}
