﻿/*
 * Adam Field
 * Assignment 5B
 * contorls mouse movement
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnApplicationFocus(bool focus)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public float mouseSensitivity = 100f;
    public GameObject player;
    private float verticalLookRotation = 0f;

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        player.transform.Rotate(Vector3.up * mouseX);

        verticalLookRotation -= mouseY;

        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(verticalLookRotation, 0f, 0f);
    }
}
