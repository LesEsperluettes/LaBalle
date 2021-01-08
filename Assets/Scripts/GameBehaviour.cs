using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    private UIManager ui;

    void Start()
    {
        ui = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ui.showPauseUI();
        }

        // TODO remove
        if (Input.GetKeyDown(KeyCode.End))
        {
            ui.showGameOverUI();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            ui.showSuccessUI();
        }
    }
}
