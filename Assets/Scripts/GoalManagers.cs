using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManagers : MonoBehaviour
{
    public Collider wallIsTrigger; 
    // public Collider wall; 
    public string side; 
    public ScoreManager manager; 
 
    private void OnTriggerEnter(Collider collision) 
    { 
        if (collision.tag == "Ball") 
        { 
            manager.AddGoals(side);
            Destroy(collision.gameObject);
        } 
    } 

    public void GameOver()
    {
        this.GetComponent<Collider>().enabled = false;
        wallIsTrigger.enabled = false;
        // wall.enabled = true;
        // Destroy(this);
    }
}
