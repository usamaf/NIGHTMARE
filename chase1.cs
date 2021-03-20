using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.AI;

public class chase1 : MonoBehaviour
{
    //public GameObject destoryEnemy;
    public static bool dead;
     GameObject player;
    public Animator anim;
    
    public bool fallback;
 
    int a;
    bool healthdec;
  //  public AudioSource ghostattacksound;
    // Use this for initialization

    IEnumerator Example()
    {
        Debug.Log("its working hahaha");

        yield return new WaitForSeconds(6f);
        anim.SetBool("block", false);

        Debug.Log("its totally working hahaha");



    }


    void Start()
    {
        player= GameObject.FindWithTag("Player");
        dead = false;
    }


    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
       // player.GetComponent<Animator>().SetBool("fallback", true);
       // playerhealth.GetComponent<Healthbar>().TakeDamage(1);
        fallback = true;
        healthdec = true;
        health.healthdecrease();
        yield return new WaitForSeconds(2);
     //   player.GetComponent<Animator>().SetBool("fallback", false);
        //After we have waited 5 seconds print the time again.
        fallback = false;
    }
    void FixedUpdate()
    {
        if (healthdec)
        {
        //    playerhealth.GetComponent<Healthbar>().TakeDamage(0.5f);
            healthdec = false;
        }
        if (fallback)
        {

         //   player.transform.position = Vector3.MoveTowards(player.transform.position, player.GetComponent<charactermove>().fallpoint.transform.position, 5 * Time.deltaTime);

        }
        if (dead == false)
        {

            if (Vector3.Distance(player.transform.position, this.transform.position) < 15)
            {
                Vector3 direction = player.transform.position - this.transform.position;
                direction.y = 0;
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                    Quaternion.LookRotation(direction), 0.1f);

                anim.SetBool("idle", false);
                if (direction.magnitude > 3f)
                {

                    anim.SetBool("walk", true);
                    anim.SetBool("attack", false);
                    anim.SetBool("idle", false);
                    this.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);

                }
                else
                {

                    anim.SetBool("walk", false);
                    anim.SetBool("idle", false);
                    anim.SetBool("attack", true);
                   
                   // ghostattacksound.Play();
                    StartCoroutine(ExampleCoroutine());
                   

                }
            }


            else
            {
                anim.SetBool("idle", true);
                anim.SetBool("walk", false);
                anim.SetBool("attack", false);

            }
        }
    }
}