using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameOver;

    private void Start()
    {
        setGameOver(false);
    }
    public bool getGameOver()
    {
        return gameOver;

    }
    public void setGameOver(bool g)
    {
        gameOver = g;
        evalutaGameState();
    }
    public void evalutaGameState()
    {
        if (gameOver)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
