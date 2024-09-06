using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI killsText;
    public TextMeshProUGUI missesText;
    public TextMeshProUGUI timeText;

    public Button mainMenuButton;

    private KillRecord killRecord;
    private MissRecord missesRecord;
    private TimerController timerController;
    private TargetSpawner targetSpawner;
    
    public GameObject gameOverObject;

    private bool gameOver = false;

    private void Start()
    {
        killRecord = GetComponent<KillRecord>();
        missesRecord = GetComponent<MissRecord>();
        timerController = GetComponent<TimerController>();
        targetSpawner = GetComponent<TargetSpawner>();

        mainMenuButton.onClick.AddListener(LoadMainMenu);
    }

    private void Update()
    {
        if (targetSpawner.targetCounter >= 10 && !gameOver)
        {
            gameOver = true;
            gameOverObject.SetActive(true);
            killsText.text = "Total Kills : " + killRecord.killCount.ToString();
            missesText.text = "Total Misses : " + missesRecord.missCount.ToString();
            timeText.text = "Result Time : " + string.Format("{0:00}:{1:00}", timerController.minutes, timerController.seconds);
        }
    }

    private void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
