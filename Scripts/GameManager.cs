using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public GameObject PausePanel;
   public void PausePanelOn()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0.0f;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !(PausePanel.activeSelf))
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0.0f;
        }
        else if (PausePanel.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1.0f;
            PausePanel.SetActive(false);
        }
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        PausePanel.SetActive(false);
    }
    public void Load1()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("1");
    }
    public void Load2()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("2");
    }
    public void Load3()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("3");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
