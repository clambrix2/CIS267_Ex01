using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attached to player
public class PlayerScore : MonoBehaviour
{
    private int playerscore;
    // Start is called before the first frame update
    void Start()
    {
        playerscore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int getScore()
    {
        return playerscore;
    }
    public void setPlayerScore(int val)
    {
        playerscore += val;
        Debug.Log(playerscore);
    }
}
