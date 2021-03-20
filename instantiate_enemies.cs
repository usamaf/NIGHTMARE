using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate_enemies : MonoBehaviour
{
    public Transform[] spawnerpoints;
    public GameObject enemyprefab;
    private float nextActionTime = 0.0f;
    int temp=7;
     
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("enemyspawn", 0,temp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void enemyspawn() {

        temp=Random.Range(4,7);
        int spawnpoint = Random.Range(0, spawnerpoints.Length);


        Instantiate(enemyprefab, spawnerpoints[spawnpoint].transform.position, this.gameObject.transform.rotation);

    }
}
