using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void loadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void exitGame()
    {
        //this only work with the build of the game.
        Application.Quit();
    }
}
