using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    // Start is called before the first frame update
    public int a;
    public GameObject cube;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        cube.transform.Translate(0, 0, a * Time.deltaTime);


        if (Input.GetKey(KeyCode.W))
        {
            cube.transform.Translate(a * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cube.transform.Translate(-a * Time.deltaTime, 0, 0);
        }


    }
}
