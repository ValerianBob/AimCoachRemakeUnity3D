using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;

    public Button play;
    public Button Exit;


    private void Start()
    {
        play.onClick.AddListener(LoagGameScene);
        Exit.onClick.AddListener(ExitGame);
    }

    private void LoagGameScene()
    {
        SceneManager.LoadScene(1);
    }

    private void ExitGame()
    {
        Debug.Log("Game exit");
        Application.Quit();
    }

}
