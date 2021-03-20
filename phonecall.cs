using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class phonecall : MonoBehaviour
{

    public Text calldialtext;
    string num;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        calldialtext.text = ""+num;


    }

    public void one()
    {

        Debug.Log("phone is dialed ");
        num = num + "1";
    }


    public void two()
    {

        Debug.Log("phone is dialed ");
        num = num + "2";
    }

    public void three()
    {

        Debug.Log("phone is dialed ");
        num = num + "3";
    }

    public void four()
    {

        Debug.Log("phone is dialed ");
        num = num + "4";
    }

    public void five()
    {

        Debug.Log("phone is dialed ");
        num = num + "5";
    }

    public void six()
    {

        Debug.Log("phone is dialed ");
        num = num + "6";
    }

    public void seven()
    {

        Debug.Log("phone is dialed ");
        num = num + "7";
    }

    public void nine()
    {
        Debug.Log("phone is dialed ");
        num = num + "9";
    }


    public void eight()
    {

        Debug.Log("phone is dialed ");
        num = num + "8";
    }

    public void steric()
    {

        Debug.Log("phone is dialed ");
        num = num + "*";
    }

    public void zero()
    {

        Debug.Log("phone is dialed ");
        num = num + "0";
    }

    public void hash()
    {

        Debug.Log("phone is dialed ");
        num = num + "#";
    }
}