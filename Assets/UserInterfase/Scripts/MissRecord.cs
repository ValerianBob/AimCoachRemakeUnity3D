using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MissRecord : MonoBehaviour
{
    private GameParameters gameParameters;
    public TextMeshProUGUI missRecordText;
    private TargetSpawner targetSpawner;

    public int missCount = 0;

    private void Start()
    {
        gameParameters = GetComponent<GameParameters>();
        targetSpawner = GetComponent<TargetSpawner>();
    }

    private void OnMouseDown()
    {
        if (!gameParameters.gameParametersMode && targetSpawner.targetCounter < 10)
        {
            missRecordText.text = (++missCount).ToString();
        }
    }
}
