/*
* Adam Field
* Challenge4
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

    public int enemiesScored = 0;


    public SpawnManagerX spawnManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;

        if (spawnManagerScript == null)
        {
            spawnManagerScript = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManagerX>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        waveText.text = "Wave Number: " + spawnManagerScript.waveCount;
        if (startText.IsActive() == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                startText.gameObject.SetActive(false);
                waveText.gameObject.SetActive(true);
                Time.timeScale = 1;
            }
        }

        if(spawnManagerScript.waveCount == 11)
        {
            Win();
        }

        if (enemiesScored >= spawnManagerScript.waveCount && spawnManagerScript.waveCount > 0)
        {
            Lose();
        }

        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.R) && startText.IsActive() == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void Win()
    {
        winCondition = true;
        winText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void Lose()
    {
        loseCondition = true;
        lostText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
