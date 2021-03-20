using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class sitincar : MonoBehaviour
    {
        public GameObject player;
        public GameObject car;

        private void Start()
        {
            
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                if (Input.GetKey(KeyCode.E))
                {
                    player.SetActive(false);
                    car.GetComponent<CarUserControl>().enabled = true;
                }

            }
        }
    }
}