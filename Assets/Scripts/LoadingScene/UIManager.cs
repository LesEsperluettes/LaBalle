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
        showSuccessUI();
        showGameOverUI();
    }

    private void hideAllUI()
    {
        this.FindObject("GameOverUI").SetActive(false);
        this.FindObject("SuccessUI").SetActive(false);
    }

    public void showGameOverUI()
    {
        hideAllUI();
        GameObject gameOverUi = this.FindObject("GameOverUI");
        gameOverUi.SetActive(true);
    }

    public void showSuccessUI()
    {
        hideAllUI();
        GameObject gameOverUi = this.FindObject("SuccessUI");
        gameOverUi.SetActive(true);
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
}
