/* Adam Field
 * Challenge2
 * manages the spawning for the balls
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    public HealthSystem healthSystem;

    // Start is called before the first frame update
    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();

        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        StartCoroutine(SpawnRandomBallCoroutine());
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        //create random number
        int rand = Random.Range(0, 3);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[rand], spawnPos, ballPrefabs[rand].transform.rotation);
    }

    IEnumerator SpawnRandomBallCoroutine()
    {
        while (!healthSystem.gameOver)
        {
            SpawnRandomBall();

            float randomDelay = Random.Range(3f, 5f);

            yield return new WaitForSeconds(randomDelay);
        }
    }

}
