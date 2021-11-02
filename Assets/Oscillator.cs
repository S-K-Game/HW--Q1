using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // The start position for the obj
    float startPosition;

    // Start is called before the first frame update
    void Start()
    {
    // Each object and its initial position
        startPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Sin(Time.time);
        transform.position = new Vector3(x + startPosition, 0.0f, 0.0f);
        
    }
}
