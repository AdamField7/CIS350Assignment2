/*
 * Adam Field
 * Assignment 5B
 * makes the trigger zone work
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneFinish : MonoBehaviour
{
    public GameObject winText;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("finish");
            YouWin();
        }
    }

    void YouWin()
    {
        winText.SetActive(true);
    }

}