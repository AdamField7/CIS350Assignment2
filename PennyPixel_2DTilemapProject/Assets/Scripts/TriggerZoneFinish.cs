/*
 * Adam Field
 * Assignment 5A
 * makes the trigger zone work
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneFinish : MonoBehaviour
{
    private UIManager uIManager;

    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("finish");
            uIManager.YouWin();
        }
    }

}
