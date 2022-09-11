/* Adam Field
 * Prototype2
 * spawn manager for prefabs
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //drag the animals to spawn into this array
    public GameObject[] animalsToSpawn;

    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    public HealthSystem healthSystem;

    private void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>(); 

        StartCoroutine(SpawnRandomPrefabCoroutine());
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomPrefab();
        }
    }

    IEnumerator SpawnRandomPrefabCoroutine()
    {
        //3 second delay
        yield return new WaitForSeconds(3f);

        while(!healthSystem.gameOver)
        {
            SpawnRandomPrefab();

            float randomDelay = Random.Range(0.8f, 2.0f);

            yield return new WaitForSeconds(randomDelay);
        }
    }

    void SpawnRandomPrefab()
    {
        //generate index
        int prefabIndex = Random.Range(0, animalsToSpawn.Length);

        //generate spawn pos
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        //spawn
        Instantiate(animalsToSpawn[prefabIndex], spawnPos, animalsToSpawn[prefabIndex].transform.rotation);
    }
}
