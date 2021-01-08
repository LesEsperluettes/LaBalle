using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTriggerBehaviour : MonoBehaviour
{
    private GameBehaviour game;

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("GameManager").GetComponent<GameBehaviour>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Sphere"))
        {
            game.onWin();
        }
    }
}
