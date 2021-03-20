using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostscare : MonoBehaviour
{
    public GameObject[] spawnitem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {


            for (int i = 0; i <= spawnitem.Length; i++) {

                spawnitem[i].SetActive(true);

            }

        }
    }
}
