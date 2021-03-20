using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragging : MonoBehaviour
{
    public float catchingDistance = 3f;
    bool isDragging = false;
    GameObject draggingObject;
   
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetMouseButton(0))
        {
            if (!isDragging)
            {
                draggingObject = GetObjectFromMouseRaycast();
                if (draggingObject)
                {
                    draggingObject.GetComponent<Rigidbody>().isKinematic = true;
                    isDragging = true;
                }
            }
            else if (draggingObject != null)
            {
                draggingObject.GetComponent<Rigidbody>().MovePosition(CalculateMouse3DVector());
            }
        }
        else
        {
            if (draggingObject != null)
            {
                draggingObject.GetComponent<Rigidbody>().isKinematic = false;
            }
            isDragging = false;
        }


        if (Input.GetKey(KeyCode.R))
        {
            draggingObject.transform.Rotate(10 * Time.deltaTime, 0, 0);
        }
    }
    private GameObject GetObjectFromMouseRaycast()
    {
        GameObject gmObj = null;
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0)), out hitInfo);
        if (hit)
        {
           

            if (hitInfo.collider.gameObject.GetComponent<Rigidbody>() &&
                Vector3.Distance(hitInfo.collider.gameObject.transform.position,
                transform.position) <= catchingDistance)
            {
                gmObj = hitInfo.collider.gameObject;
            }
        }
       
        return gmObj;
    }
    private Vector3 CalculateMouse3DVector()
    {
        Vector3 v3 = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        v3.z = catchingDistance;
        v3 = Camera.main.ScreenToWorldPoint(v3);
        Debug.Log(v3); //Current Position of mouse in world space
        return v3;
    }
    }