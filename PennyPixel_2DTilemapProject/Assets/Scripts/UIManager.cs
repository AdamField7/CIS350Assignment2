/*
 * Adam Field
 * Assignment 5A
 * controls UI for the game
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject winText;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        scoreText.text = "Gems: 0/10";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Gems: " + score + "/10";
    }

    public void YouWin()
    {
        winText.SetActive(true);
    }
}