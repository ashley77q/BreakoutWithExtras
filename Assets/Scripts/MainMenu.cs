using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string MainGame;

    public void NewGame()
    {


        SceneManager.LoadScene("MainGame");


    }



    public void QuitGame()
    {

        Application.Quit();


    }
}
