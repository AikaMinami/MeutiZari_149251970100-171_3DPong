using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayer : MonoBehaviour
{
    public Text player1ScoreText; 
    public Text player2ScoreText; 
    public Text player3ScoreText; 
    public Text player4ScoreText; 
 
    public ScoreManager manager; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1ScoreText.text = manager.player1Score.ToString(); 
        player2ScoreText.text = manager.player2Score.ToString(); 
        player3ScoreText.text = manager.player3Score.ToString(); 
        player4ScoreText.text = manager.player4Score.ToString(); 
    }
}
