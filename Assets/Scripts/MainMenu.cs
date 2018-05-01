using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{


    void Awake()
    {

    }
    public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("quit!");
        Application.Quit();
    }

    void SetBestText()
    {
        //currentText.text = "Your Distance: " + current.ToString();
    }
}