/*
* Adam Field
* Challenge4
* Controls enemies
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    private SpawnManagerX spawnManagerXScript;
    private UIManager UIManagerScript;
    public int speedModifier;

    // Start is called before the first frame update
    void Start()
    {
        if (spawnManagerXScript == null)
        {
            spawnManagerXScript = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManagerX>();
        }
        if (UIManagerScript == null)
        {
            UIManagerScript = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        }

        Debug.Log("wave count = " + spawnManagerXScript.waveCount);
        speed = spawnManagerXScript.waveCount * speedModifier;
        Debug.Log("speed = " + speed);

        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.FindGameObjectWithTag("PlayerGoal");
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
            UIManagerScript.enemiesScored++;
        }

    }

}
