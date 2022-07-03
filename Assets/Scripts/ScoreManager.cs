using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int player1Score = 0;
    public int player2Score = 0;
    public int player3Score = 0;
    public int player4Score = 0;
    public int maxScore;
    private int losePlayer = 0;
    public GoalManagers wall1, wall2, wall3, wall4;
    private GoalManagers goals;

    void Update()
    {
        
    }

   public void AddGoals(string side)
   {
        switch(side)
            {
                case "Player1":
                    player1Score++;
                    if (player1Score >= maxScore) 
                    { 
                        GameOver(wall1); 
                        losePlayer++;
                    }
                    break;
                case "Player2":
                    player2Score++;
                    if (player2Score >= maxScore) 
                    { 
                        GameOver(wall2); 
                        losePlayer++;
                    }
                    break;
                case "Player3":
                    player3Score++;
                    if (player3Score >= maxScore) 
                    { 
                        GameOver(wall3); 
                        losePlayer++;
                    }
                    break;
                case "Player4":
                    player4Score++;
                    if (player4Score >= maxScore) 
                    { 
                        GameOver(wall4); 
                        losePlayer++;
                    }
                    break;
                
            } 
   }

   void GameOver(GoalManagers wall)
   {
        Destroy(wall);
   }
}
