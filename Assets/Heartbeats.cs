using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartbeats : MonoBehaviour
{
    float minSize= 1.0f;
    float maxSize=2.0f;
    float growthRate=0.0025f;
   
    // Start is called before the first frame update
    void Start()
    {
 
    }

    void Update() {
        Transform t= GetComponent <Transform>();

        if(t.localScale.x < minSize) {
         growthRate = Mathf.Abs(growthRate);
        }
        else if(t.localScale.x > maxSize) {
         growthRate = -Mathf.Abs(growthRate);
        }
        t.localScale += Vector3.one * growthRate;
        
    }
}