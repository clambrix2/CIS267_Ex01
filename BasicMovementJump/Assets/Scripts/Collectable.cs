using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Start is called before the first frame update
    public int collectableValue;
    //need a reference to the Playerscore.cs script it on the player.
    public GameObject playerObject;
    private PlayerScore gamescore;
    void Start()
    {
        //find the object that has playerscore.cs script. do not use .find unless you abuslute have to
        //by makeing the playerObject variablel public we can use unity editoy to link the variable with the object
        //this sill allow us to access the script

        // cannot just use getcomponment because playerscore.cs is not attacjed to the collectable
        gamescore = playerObject.GetComponent<PlayerScore>();
    }


    public void destoryCollectable()
    {
        Destroy(this.gameObject);
    }
    public int getCollectableValue()
    {
        return collectableValue;
    }
    public void setCollectableValue(int value)
    {
        collectableValue = value;
    }
}
