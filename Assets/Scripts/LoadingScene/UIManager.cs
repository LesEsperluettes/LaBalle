using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public List<GameObject> prefabsToInst;

    public AudioSource audioSource;
    public AudioClip deadSound;
    public AudioClip winSound;
    public AudioClip pauseSound;

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

    private void playSound(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
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
        hideUI("GameOverUI");
        hideUI("SuccessUI");
        hideUI("PauseUI");
    }

    private void showUI(string name)
    {
        hideAllUI();
        GameObject gameOverUi = this.FindObject(name);
        gameOverUi.SetActive(true);
    }

    public void hideUI(string name)
    {
        this.FindObject(name).SetActive(false);
    }

    public void showGameOverUI()
    {
        playSound(deadSound);
        showUI("GameOverUI");
    }

    public void showSuccessUI()
    {
        playSound(winSound);
        showUI("SuccessUI");
    }

    public void showPauseUI()
    {
        playSound(pauseSound);
        Time.timeScale = 0;
        showUI("PauseUI");
    }
}
