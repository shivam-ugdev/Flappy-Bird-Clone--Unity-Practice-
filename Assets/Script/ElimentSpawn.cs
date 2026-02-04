using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElimentSpawn : MonoBehaviour
{
    public GameObject tree;
    private float timeForSpawn;
    public float spawnTime;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (timeForSpawn <= 0)
        {
            Instantiate(tree, transform.position, transform.rotation);
            timeForSpawn = spawnTime;
        }
        else
        {
           timeForSpawn  -= Time.deltaTime;
        }
    }
    
}
