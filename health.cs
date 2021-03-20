using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public static float currenthealth = 100;
   static float hash;
    public GameObject levelfail;
    static  GameObject healthbar;
    // Start is called before the first frame update
    void Start()
    {
        healthbar = GameObject.FindWithTag("healthbar");
    }

    // Update is called once per frame
    void Update()
    {
        if (currenthealth < 0) {
            levelfail.SetActive(true);
        }
    }

  public static void healthdecrease() {

        currenthealth -= 15 * Time.deltaTime;
        hash = currenthealth / 100;

        healthbar.GetComponent<Image>().fillAmount = hash;

    }

}
