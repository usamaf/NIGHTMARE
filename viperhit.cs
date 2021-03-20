using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viperhit : MonoBehaviour
{


    public bool canattack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

            if (Input.GetKeyDown(KeyCode.Q))
        {
            this.gameObject.GetComponent<Animator>().Play("viperhit");

            StartCoroutine(ExampleCoroutine());
          

        }
       
    }
    IEnumerator ExampleCoroutine()
    {
        canattack = true;
        yield return new WaitForSeconds(0.5f);
        this.gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        canattack = false;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy" && canattack) {

           // other.gameObject.SetActive(false);
             other.gameObject.GetComponent<Animator>().SetBool("die", true);
            other.gameObject.GetComponent<AudioSource>().enabled = false;
            other.gameObject.GetComponent<chase1>().enabled = false;
           
        }
    }
}
