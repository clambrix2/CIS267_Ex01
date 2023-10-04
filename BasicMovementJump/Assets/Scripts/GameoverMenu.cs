using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverMenu : MonoBehaviour
{
    //drag and drop object
    public GameObject gameManager;
    public GameObject GameOverMenu;
    private GameManager gm;
    void Start()
    {
        gm = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.getGameOver() == true)
        {
            showGameOverMenu();
        }
    }
    private void showGameOverMenu()
    {
        GameOverMenu.SetActive(true);
    }
    public void exitGame()
    {
        Application.Quit();
    }
    public void restartGame()
    {
        gm.setGameOver(false);
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("SampleScene");

    }
   
}
