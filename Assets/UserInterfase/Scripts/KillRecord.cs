using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KillRecord : MonoBehaviour
{
    public TextMeshProUGUI killRecordText;

    public int killCount = 0;

    private void Update()
    {
        killRecordText.text = killCount.ToString();
    }
}
