using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{
    private UIManager ui;

    void Start()
    {
        ui = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    public void GoBackToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void Retry()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void GoToNextLevel()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextScene < SceneManager.sceneCountInBuildSettings) SceneManager.LoadScene(nextScene);
        else GoBackToMainMenu();
    }

    public void Resume()
    {
        Time.timeScale = 1;
        ui.hideUI("PauseUI");
    }
}
