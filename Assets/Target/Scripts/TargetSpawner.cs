using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    private GameParameters gameParameters;
    public GameObject target;

    private float xPosition = 8.4f;
    private float yPosition = 4.5f;
    private float spawnSpeed = 1f;

    private bool gameStarted = false;

    public int targetCounter = 0;

    private void Start()
    {
        gameParameters = GetComponent<GameParameters>();
    }

    private void Update()
    {
        if (!gameParameters.gameParametersMode && !gameStarted)
        {
            spawnSpeed = gameParameters.spawnSpeed;
            StartCoroutine("GenerateTarget");
            gameStarted = true;
        }

        if (targetCounter >= 10)
        {
            StopCoroutine("GenerateTarget");
        }
    }

    IEnumerator GenerateTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnSpeed);
            Instantiate(target, GetRandomPosition(), target.transform.rotation);
            targetCounter += 1;
        }
    }

    private Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(-xPosition, xPosition), Random.Range(-yPosition, yPosition), 0);
    }
}
