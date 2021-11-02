using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour
{
   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            if(rend.enabled)
                rend.enabled = false;
            else
                rend.enabled = true;
        }
    }
}
