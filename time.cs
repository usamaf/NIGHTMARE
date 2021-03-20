using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public Text text;
    public float timeLeft;
     
    public GameObject turnoff;

    public GameObject turnon;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft >= 0)
        {

            int min = Mathf.FloorToInt(timeLeft / 60);
            int sec = Mathf.FloorToInt(timeLeft % 60);
            timeLeft = timeLeft - 1 * Time.deltaTime;
            text.GetComponent<UnityEngine.UI.Text>().text = min.ToString("00") + ":" + sec.ToString("00");

        }
        else
        {
            turnoff.SetActive(false);

            turnon.SetActive(true);

        }

    }
}
