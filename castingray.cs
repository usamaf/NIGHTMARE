using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
namespace UnityStandardAssets.Characters.FirstPerson
{
    [RequireComponent(typeof(CharacterController))]
    public class castingray : MonoBehaviour
    {
        public PostProcessProfile objectzooomProfile;
        public PostProcessProfile normalProfile;
        public GameObject f;
        public GameObject objui;
        public GameObject directionalui;
        bool objectzoommode;
        public Camera UICam;
        public GameObject normaldot;
        public GameObject selobjui;
        public GameObject focusdot;
       
        public GameObject patientrec;
        bool uiimagedisp;
        public GameObject doorui;

        Animator door;
        bool open;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0)), out hitInfo,3);
            if (hit)
            {
                door = hitInfo.collider.GetComponent<Animator>();

                if (hitInfo.collider.tag == "Door")
                {

                    doorui.SetActive(true);
                    doorui.transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 0);

                    if (Input.GetKeyDown(KeyCode.E))
                    {


                        doorui.SetActive(false);
                        Debug.Log("collide");
                        door.SetBool("open", true);
                        open = true;

                    }

                    if (Input.GetKeyDown(KeyCode.Q))
                    {

                        doorui.SetActive(false);

                        if (open)
                        {

                            Debug.Log("collide");
                            door.SetBool("open", false);
                            open = false;
                        }

                    }


                }


                else {
                    doorui.SetActive(false);
                }


                if (hitInfo.collider.tag == "uiimage")
                {
                    selobjui.SetActive(true);
                    selobjui.transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 0);
                     

                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        patientrec.SetActive(true);
                        uiimagedisp = true;
                    } }
                else {
                    patientrec.SetActive(false);
                }

                if (Input.GetKeyDown(KeyCode.Q))
                {
                    uiimagedisp = false;
                    patientrec.SetActive(false);
                }

                    if (hitInfo.collider.tag == "drag")
                {
                    focusdot.SetActive(true);
                    normaldot.SetActive(false);


                }
                else
                {
                    focusdot.SetActive(false);
                    normaldot.SetActive(true);

                }
                if (hitInfo.collider.tag == "uiobject")
                {
                    selobjui.SetActive(true);
                    selobjui.transform.position= new Vector3(Screen.width / 2, Screen.height / 2, 0);
                  
                   
                    //     UICam.transform.Translate(0, 0, -1f);
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        UICam.transform.position = hitInfo.collider.transform.position;
                        UICam.transform.Translate(0, 0, -1);

                        hitInfo.collider.GetComponent<turn>().enabled = true;
                        f.GetComponent<PostProcessVolume>().profile = objectzooomProfile;

                        f.GetComponent<CharacterController>().enabled = false;
                        f.GetComponent<FirstPersonController>().enabled = false;
                        objectzoommode = true;
                        directionalui.SetActive(true);
                        objui.SetActive(true);

                    }
                }
                else
                {
                    
                    selobjui.SetActive(false);
                }


            }
            if (objectzoommode) {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    hitInfo.collider.GetComponent<turn>().enabled = false;
                    f.GetComponent<PostProcessVolume>().profile = normalProfile;

                    f.GetComponent<CharacterController>().enabled = true;
                    f.GetComponent<FirstPersonController>().enabled = true;
                    objectzoommode = false;
                    objui.SetActive(false);
                    directionalui.SetActive(false);
                }
            }


        }
    }
}