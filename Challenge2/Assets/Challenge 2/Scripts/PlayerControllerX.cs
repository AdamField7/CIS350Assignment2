﻿/* Adam Field
 * Challenge2
 * controls the spawning of the dogs
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer <= 0f)
        {
            timer = 2f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
