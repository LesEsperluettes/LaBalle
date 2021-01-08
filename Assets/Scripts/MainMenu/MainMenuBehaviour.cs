using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehaviour : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
