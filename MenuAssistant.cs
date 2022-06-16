using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuAssistant : MonoBehaviour
{
    public GameObject startingMenuPanel;
    public Text endingsdiscoveredText;
    public GameObject pauseMenuPanel;
    public GameObject finishPanel;
    public Text answerText;

    public GameObject player;
    public GameObject playerPrefab;
    StarterAssets.FirstPersonController playerRef;

    public GameObject endingAss;
    public GameObject finish;
    FinishTrigger finTrigger;

    public GameObject sea;
    // Start is called before the first frame update
    void Start()
    {
        startingMenuPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerRef)
        {
            if (playerRef.escapePressed)
            {
                if(playerRef.escapeActive)
                    PauseMenu(true, 0);
                else
                    PauseMenu(false, 1);
            }
        }
        if(finTrigger)
        {
            if(finTrigger.levelFinished)
            {
                answerText.text = "\t" + finTrigger.answer;
                finish.SetActive(false);
                finishPanel.SetActive(true);
                endingAss.GetComponent<EndingsAssistant>().NextFinish();
                finTrigger = null;
                Time.timeScale = 0f;
            }
        }
    }

    public void StartGame()
    {
        startingMenuPanel.SetActive(false);
        if (player)
            Destroy(player);
       
        player = Instantiate(playerPrefab);
        playerRef = player.GetComponent<StarterAssets.FirstPersonController>();
        player.SetActive(true);

        finish = endingAss.GetComponent<EndingsAssistant>().currFinish;
        finTrigger = finish.GetComponent<FinishTrigger>();
    }

    public void PauseMenu(bool enableValue, float timeValue)
    {

        pauseMenuPanel.SetActive(enableValue);
        Time.timeScale = timeValue;
    }

    public void ExitToMainMenu()
    {
        sea.SetActive(true);
        finishPanel.SetActive(false);
        pauseMenuPanel.SetActive(false);
        endingsdiscoveredText.text = "Endings Discovered: " + (endingAss.GetComponent<EndingsAssistant>().index)+ "/4";
        startingMenuPanel.SetActive(true);

        if (player)
        {
            Destroy(player);
            playerRef = null;
        }
        Time.timeScale = 1f;
            
    }
}
