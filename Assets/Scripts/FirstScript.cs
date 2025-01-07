using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;

        //This is what we test on the right
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 screenSizeInTheWorld = new Vector2();
        screenSizeInTheWorld = Camera.main.ScreenToWorldPoint(screenSize);

        //This is what we test on the left
        Vector2 screenZeroInTheWorld = Camera.main.ScreenToWorldPoint(Vector2.zero);

        if (pos.x < screenZeroInTheWorld.x || pos.x > screenSizeInTheWorld.x)
        {
            speed *= -1;
        }

        transform.position = pos;
    }
}
