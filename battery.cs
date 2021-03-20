using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class battery : MonoBehaviour
{
    public Image bar;
    public Image batterylife;
    public GameObject levelfailpanel;
    public float current=99f;
    public float max = 99f;
    public float burnrate = 0.05f;
    public Text batterytext;
    public Text batterypercent;


    void Update()
    {
        float hash = current / max;
        current -= burnrate * Time.deltaTime;

        int currentbatt = (int)current;

        batterytext.text = "" +currentbatt.ToString();
        batterypercent.text =currentbatt.ToString()+" %"; 
        if (hash < 0)
        {
            levelfailpanel.SetActive(true);
         
       
        }

        seth(hash);
    }

    void seth(float myh)
    {

        bar.fillAmount = myh;
        batterylife.fillAmount = myh;
    }
}
