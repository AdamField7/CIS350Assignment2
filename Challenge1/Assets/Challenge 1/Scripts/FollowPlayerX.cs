/*
 * Adam Field
 * Challenge1
 * contorls the camera so it follows the player
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(20.54221f, 3.638938f, 1.355707f);

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
