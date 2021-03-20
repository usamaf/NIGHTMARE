using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidattach : MonoBehaviour
{

   public GameObject [] myGameObject;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < +myGameObject.Length; i++)
        {
            Rigidbody gameObjectsRigidBody = myGameObject[i].AddComponent<Rigidbody>(); // Add the rigidbody.

            gameObjectsRigidBody.mass = 5; // Set the GO's mass to 5 via the Rigidbody.

        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
