using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicking : MonoBehaviour
{
    const float k_Spring = 50.0f;
    const float k_Damper = 5.0f;
    const float k_Drag = 10.0f;
    const float k_AngularDrag = 5.0f;
    const float k_Distance = 0.2f;
    const bool k_AttachToCenterOfMass = false;

    private SpringJoint m_SpringJoint;
    public GameObject light;
    public GameObject texts;
    public GameObject BUTTON;
    shaderGlow abc;
    public GameObject x;

    private void Update()
    {
        // Make sure the user pressed the mouse down


       

        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }

        var mainCamera = FindCamera();

        // We need to actually hit an object

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit = new RaycastHit();
        if (
            !Physics.Raycast(ray, out hit, 100)){
            return;
        }
        // We need to hit a rigidbody that is not kinematic
        if (!hit.rigidbody || hit.rigidbody.isKinematic)
        {
            return;
        }

        if (!m_SpringJoint)
        {
          
        }

      

        StartCoroutine("DragObject", hit.distance);
    }

    private IEnumerator DragObject(float distance)
    {
      
        var mainCamera = FindCamera();
        while (Input.GetMouseButton(0))
        {

            Debug.Log("dsadsa");
            light.SetActive(true);

            Destroy(BUTTON);
            texts.SetActive(true);

            x.SetActive(true);
            Debug.Log(abc);
            yield return null;
        } 
    }
    private Camera FindCamera()
    {
        if (GetComponent<Camera>())
        {
            return GetComponent<Camera>();
        }

        return Camera.main;
    }
}
