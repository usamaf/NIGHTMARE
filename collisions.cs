using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    public GameObject af;


    private void OnTriggerEnter(Collider other)
    { 

            Debug.Log("Collision");


       
        af.SetActive(true);
    }
}
