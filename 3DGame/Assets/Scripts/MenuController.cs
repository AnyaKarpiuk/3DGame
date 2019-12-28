using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public void startButton()
    {
    	SceneManager.LoadScene(0);
    }

    public void quitButton()
    {
    	Application.Quit();
    }

    public void returnToMenu()
    {
    	SceneManager.LoadScene(1);
    }
}
