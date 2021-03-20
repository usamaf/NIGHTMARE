using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors : MonoBehaviour
{

    
    bool keypress;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            keypress = true;
        }
        else { keypress = false; }
    }

    private void OnTriggerEnter(Collider other)
    {
      
        }
    }
