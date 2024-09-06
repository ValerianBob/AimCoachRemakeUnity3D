using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class TargetController : MonoBehaviour
{
    private GameParameters gameParameters;
    private KillRecord records;
    private TargetSpawner targetSpawner;

    private Vector3 newSize;

    private void Start()
    {
        gameParameters = GameObject.Find("Background").GetComponent<GameParameters>();
        records = GameObject.Find("Background").GetComponent<KillRecord>();
        targetSpawner = GameObject.Find("Background").GetComponent<TargetSpawner>();

        newSize = new Vector3(gameParameters.targetSize, gameParameters.targetSize, gameParameters.targetSize);
        transform.localScale = newSize;
    }

    private void OnMouseDown()
    {
        if (targetSpawner.targetCounter < 10)
        {
            records.killCount += 1;
            targetSpawner.targetCounter -= 1;
            Destroy(gameObject);
        }
    }
}
