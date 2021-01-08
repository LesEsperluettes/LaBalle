using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public List<GameObject> prefabsToInst;

    void Start()
    {
        foreach(GameObject prefab in prefabsToInst)
        {
            GameObject toAdd = Instantiate(prefab);
            toAdd.name = prefab.name;
            toAdd.transform.SetParent(transform);
            toAdd.SetActive(false);
        }
    }

    private GameObject FindObject(string name)
    {
        Transform[] trs = this.GetComponentsInChildren<Transform>(true);
        foreach (Transform t in trs)
        {
            if (t.name == name)
            {
                return t.gameObject;
            }
        }
        return null;
    }

    private void hideAllUI()
    {
        this.FindObject("GameOverUI").SetActive(false);
        this.FindObject("SuccessUI").SetActive(false);
        this.FindObject("PauseUI").SetActive(false);
    }

    private void showUI(string name)
    {
        hideAllUI();
        GameObject gameOverUi = this.FindObject(name);
        gameOverUi.SetActive(true);
    }

    public void showGameOverUI()
    {
        showUI("GameOverUI");
    }

    public void showSuccessUI()
    {
        showUI("SuccessUI");
    }

    public void showPauseUI()
    {
        Time.timeScale = 0;
        showUI("PauseUI");
    }
}
