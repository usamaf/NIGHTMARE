using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggeron_off : MonoBehaviour
{
    public GameObject[] spawnitem;
    public GameObject turnoffitem;

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

        this.gameObject.SetActive(false);
        if (other.gameObject.tag == "Player")
        {
            turnoffitem.SetActive(false);


            for (int i = 0; i <  spawnitem.Length; i++)
            {

                spawnitem[i].SetActive(true);

            }

          
                

         

        }
    }
}
