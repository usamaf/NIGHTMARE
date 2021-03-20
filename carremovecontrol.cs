using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class carremovecontrol : MonoBehaviour
    {

        public GameObject car;
        // Start is called before the first frame update
        void Start()
        {
            car.GetComponent<CarUserControl>().enabled = false;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}