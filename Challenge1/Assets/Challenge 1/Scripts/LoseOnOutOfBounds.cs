/*
 * Adam Field
 * Challenge1
 * if player flys out of map the game is over
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnOutOfBounds : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -51 || transform.position.y > 80)
        {
            ScoreManager.gameOver = true;
        }
    }
}
