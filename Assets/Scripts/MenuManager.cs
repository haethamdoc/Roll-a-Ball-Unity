using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{ 
 

    public void GoToGame()
    {
        SceneManager.LoadScene("GameScene"); 
    } 

    void OnQuit(InputValue quitValue)
    {
        Debug.Log("Hitting Quit Button");
        Application.Quit();
    }

    void OnMenu(InputValue mainMenuValue)
    {
        Debug.Log("Hitting Menu Button");
        SceneManager.LoadScene("MainMenu");
    }


}
