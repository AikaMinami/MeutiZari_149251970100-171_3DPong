using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManagers : MonoBehaviour
{
    // public Collider ball; 
    public string side; 
    public ScoreManager manager; 
 
    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        if (collision.tag == "Ball") 
        { 
            switch(side)
            {
                case "Player1":
                    Debug.Log("Goal");
                    break;
                
            } 
        } 
    } 

    public void GameOver()
    {
        Destroy(this);
    }
}
