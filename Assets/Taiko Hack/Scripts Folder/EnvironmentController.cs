using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{

    public GameObject environmentPrefabs;
    public float spawnAreaSize = 10f;

    public List<GameObject> objectsToEnable;
    private float spawnCount = 0;

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

       Quaternion spawnRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);


       Instantiate(environmentPrefabs, spawnPosition, spawnRotation);

       spawnCount++;

       if (spawnCount == 10)
       {
            objectsToEnable[0].SetActive(true);
       }
    }
}
