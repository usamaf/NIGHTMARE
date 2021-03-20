using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement1 : MonoBehaviour
{
    public Transform cube;

    public int a=10;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey (KeyCode.D)) {
            cube.transform.Translate(0, 0, 1*Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.A))
        {
            cube.transform.Translate(0, 0, -1 * Time.deltaTime);
        }

        if (Input.GetKey (KeyCode.W))
        {
            cube.transform.Translate( 1, 0,  0);
        }

        if (Input.GetKey (KeyCode.S))
        {
            cube.transform.Translate(-1, 0, 0);
        }
    }
}
