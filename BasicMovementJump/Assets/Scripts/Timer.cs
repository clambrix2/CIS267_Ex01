using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float time;
    private TMP_Text guiTime;
    public GameObject gameManager;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = gameManager.GetComponent<GameManager>();
        time = 20;
        guiTime = GetComponent<TMP_Text>();
        updateGuiTime();
    }

    // Update is called once per frame
    void Update()
    {
        timerTick();
    }
    public void timerTick()
    {
        
        if (timeup())
        {
            gm.setGameOver(true);
            time = 0;
            updateGuiTime();
        }
        else
        {
            time -= Time.deltaTime;
            updateGuiTime();
        }
    }
    public void updateGuiTime()
    {
    guiTime.text = "Time: " + time;
    }
    public bool timeup()
    {
        if(time <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
