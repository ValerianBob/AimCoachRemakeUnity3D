using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameParameters : MonoBehaviour
{
    public GameObject gameParameters;

    public TMP_InputField inputTargetSize;
    public TMP_InputField inputSpawnSpeed;
    public Button buttonStart;

    public TextMeshProUGUI errorMessageText;

    public bool gameParametersMode = true;
    public float targetSize;
    public float spawnSpeed;

    private void Start()
    {
        buttonStart.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        try
        {
            targetSize = float.Parse(inputTargetSize.text);
            spawnSpeed = float.Parse(inputSpawnSpeed.text);
        }
        catch
        {
        }

        if (CheckCorrectInputParameters())
        {
            gameParameters.SetActive(false);
            gameParametersMode = false;
        }
        else
        {
            errorMessageText.text = "Number must be from 0,1 to 1. Pls use only numbers. Use , for decimal numbers !";
        }
    }

    private bool CheckCorrectInputParameters()
    {
        if (targetSize >= 0.1f && targetSize <= 1f)
        {
            if (spawnSpeed >= 0.1f && spawnSpeed <= 1f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
