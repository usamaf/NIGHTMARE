using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personsaved : MonoBehaviour
{
    public GameObject thankyounote;

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

            this.gameObject.GetComponent<Animator>().SetBool("idle", true);
            thankyounote.SetActive(true);
        }
    }
}
