using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// attached to player
public class PlayerScore : MonoBehaviour
{
    private int playerscore;
    public TMP_Text guiscore;
    // Start is called before the first frame update
    void Start()
    {
        playerscore = 0;
    }

    // Update is called once per frame
  
    public int getScore()
    {
        return playerscore;
    }
    public void setPlayerScore(int val)
    {
        playerscore += val;
        guiscore.text = playerscore.ToString();
        Debug.Log(playerscore);
    }
}
