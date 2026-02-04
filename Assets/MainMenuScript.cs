using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public GameObject creditsPanel;

    private void Start()
    {
        creditsPanel.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void back() 
    {
        creditsPanel.SetActive(false);
    }
    public void Credits()
    {
        creditsPanel.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quitgame");
    }
}
