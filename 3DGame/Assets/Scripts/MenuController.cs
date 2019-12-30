using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    //play music at the moment game is started
    public void Start()
    {
        FindObjectOfType<AudioManager>().Play("BackgroundMusic");
    }

    //load scenes and add sound when the button is clicked
    public void startButton()
    {
    	SceneManager.LoadScene(1);
        FindObjectOfType<AudioManager>().Play("Button");
    }

    public void quitButton()
    {
    	Application.Quit();
        FindObjectOfType<AudioManager>().Play("Button");
    }

    public void returnToMenu()
    {
    	SceneManager.LoadScene(0);
        FindObjectOfType<AudioManager>().Play("Button");
    }

    public void tutorialButton()
    {
        FindObjectOfType<AudioManager>().Play("Button");
    }
}
