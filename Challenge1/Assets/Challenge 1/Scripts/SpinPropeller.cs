/*
 * Adam Field
 * Challenge1
 * spins the planes propeller
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, 10f, Space.Self);
    }
}
