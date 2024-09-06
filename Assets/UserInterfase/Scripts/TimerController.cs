using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    private GameParameters gameParameters;
    public TextMeshProUGUI timerText;
    private TargetSpawner targetSpawner;

    public int seconds = 0;
    public int minutes = 0;

    private bool gameStarted = false;

    private void Start()
    {
        gameParameters = GetComponent<GameParameters>();
        targetSpawner = GetComponent<TargetSpawner>();
    }

    private void Update()
    {
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (!gameParameters.gameParametersMode && !gameStarted)
        {
            StartCoroutine("Timer");
            gameStarted = true;
        }
        
        if (targetSpawner.targetCounter >= 10)
        {
            StopCoroutine("Timer");
        }
    }

    IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            seconds += 1;

            if (seconds == 60)
            {
                minutes += 1;
                seconds = 0;
            }
        }
    }
}
