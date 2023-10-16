using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sawcontroller : MonoBehaviour
{
    public float movementspeed;
    public float offset;
    private bool moveup;
    private float startPosy;
   
    // Start is called before the first frame update
    void Start()
    {
       startPosy = transform.position.y;
        
        moveup = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveSaw();
       
    }
    public void moveSaw()
    {
        //move the saw down
        if(moveup)
        {
            transform.Translate(Vector2.up * movementspeed * Time.deltaTime);
            
        }
        else 
        {
            transform.Translate(Vector2.down * movementspeed * Time.deltaTime);

        }
        if(transform.position.y >= startPosy)
        {
            moveup = false;
        }
        if(transform.position.y <= startPosy - offset)
        {
            moveup = true;
        }
        
            
       
            
        
            
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Dead");
        }
    }
}
