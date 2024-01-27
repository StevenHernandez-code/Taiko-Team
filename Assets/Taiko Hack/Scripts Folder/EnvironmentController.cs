using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{

    public GameObject environmentPrefabs;
    public float spawnAreaSize = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPrefab()
    {
       float x = Random.Range(-spawnAreaSize / 2, spawnAreaSize / 2);
       float z = Random.Range(-spawnAreaSize / 2, spawnAreaSize / 2);
       Vector3 spawnPosition = new Vector3(x, 0, z);

       Instantiate(environmentPrefabs, spawnPosition, Quaternion.identity);
    }
}
