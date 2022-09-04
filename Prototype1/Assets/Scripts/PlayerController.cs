/*
 * Adam Field
 * Prototype1
 * controls player movement
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    public float forwardInput;
    public float turnSpeed;

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //move forward with forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //rotate player with horizontal input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
