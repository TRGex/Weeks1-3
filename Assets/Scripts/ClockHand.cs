using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHand : MonoBehaviour
{

    public float hourLength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spin = transform.eulerAngles;
        spin.z -= hourLength;
        transform.eulerAngles = spin;
    }
}
