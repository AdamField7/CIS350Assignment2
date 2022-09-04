/*
 * Adam Field
 * Prototype1
 * if player falls off map the game is over
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnFall : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1 )
        {
            ScoreManager.gameOver = true;
        }
    }
}
