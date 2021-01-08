using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    private UIManager ui;

    void Start()
    {
        Time.timeScale = 1;
        ui = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ui.showPauseUI();
        }
    }

    public void onDeath()
    {
        Time.timeScale = 0;
        ui.showGameOverUI();
    }

    public void onWin()
    {
        Time.timeScale = 0;
        ui.showSuccessUI();
    }
}
