using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
    public float spawnAreaSize = 10f;
    public List<GameObject> environmentPrefabs; // List of prefabs

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
       GameObject prefabToSpawn = environmentPrefabs[Random.Range(0, environmentPrefabs.Count)]; 

       float x = Random.Range(-spawnAreaSize / 2, spawnAreaSize / 2);
       float z = Random.Range(-spawnAreaSize / 2, spawnAreaSize / 2);
       Vector3 spawnPosition = new Vector3(x, 0, z);

       Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }
}
