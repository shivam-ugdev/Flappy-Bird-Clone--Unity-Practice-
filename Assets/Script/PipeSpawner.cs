using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe;

    private float timeBtwSpawn;

    public float StartSpawnTime;
    private Vector3 SpawnPos;
    float yPos;

    public float pipeCreated;
    public float mileStone = 5;
    private float currentMileStone;

    void Start()
    {
        timeBtwSpawn = StartSpawnTime;  
        currentMileStone = mileStone;
    }

    // Update is called once per frame
    void Update()
    {
        yPos = Random.Range(-0.6f, 4.0f);
        SpawnPos = new Vector3(transform.position.x, yPos, transform.position.z);
        if (timeBtwSpawn <= 0)
        {
            Instantiate(pipe, SpawnPos, transform.rotation);
            timeBtwSpawn = StartSpawnTime;
            pipeCreated++;
            if (pipeCreated >= currentMileStone)
            {
                StartSpawnTime = Mathf.Max(1.5f, StartSpawnTime - 0.23f);  
                currentMileStone += mileStone;  
            }
        }
        else 
        {
            timeBtwSpawn = timeBtwSpawn - Time.deltaTime;
        }
        
    }
}
