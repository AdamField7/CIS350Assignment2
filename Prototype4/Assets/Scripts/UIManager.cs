/*
* Adam Field
* Prototype4
* Manages the timescale of the game and the UI
*/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text lostText;
    public Text winText;
    public Text startText;
    public Text waveText;

    public bool loseCondition = false;
    public bool winCondition = false;


    public SpawnManager spawnManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;

        if (spawnManagerScript == null)
        {
            spawnManagerScript = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        waveText.text = "Wave Number: " + spawnManagerScript.waveNumber;
        if(startText.IsActive() == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                startText.gameObject.SetActive(false);
                waveText.gameObject.SetActive(true);
                Time.timeScale = 1;
            }
        }

        if (loseCondition == true)
        {
            lostText.gameObject.SetActive(true);
        }

        if (winCondition == true)
        {
            winText.gameObject.SetActive(true);
        }

        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.R) && startText.IsActive() == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void Win()
    {
        winCondition = true;
    }

    public void Lose()
    {
        loseCondition = true;
    }
}
