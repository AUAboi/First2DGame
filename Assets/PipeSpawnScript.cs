using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float yOffset = 10;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;

        }

    }



    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - yOffset;
        float heightOffset = transform.position.y + yOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heightOffset), 0), transform.rotation);
    }
}
