using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    
    public Transform spawnArea; 
    public int maxBallAmount; 
    public int spawnInterval; 
    public Vector3 ballAreaMin; 
    public Vector3 ballAreaMax;
    public List<GameObject> ballTemplateList; 
 
    private List<GameObject> ballList;
    private float timer;  
    void Start()
    {
        ballList = new List<GameObject>(); 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 
 
        if (timer > spawnInterval) 
        { 
            GenerateRandomBall(); 
            timer -= spawnInterval; 
        } 
    }

     public void GenerateRandomBall() 
    { 
        GenerateRandomBall(new Vector3(Random.Range(ballAreaMin.x, ballAreaMax.x), Random.Range(ballAreaMin.y, ballAreaMax.y), Random.Range(ballAreaMin.z, ballAreaMax.z))); 
    } 

    public void GenerateRandomBall(Vector2 position) 
    { 
        if (ballList.Count >= maxBallAmount) 
        { 
            return; 
        } 
 
        if (position.x < ballAreaMin.x || 
            position.x > ballAreaMax.x || 
            position.y < ballAreaMin.y || 
            position.y > ballAreaMax.y) 
        { 
            return; 
        } 
 
        int randomIndex = Random.Range(0, ballTemplateList.Count); 
 
        GameObject ball = Instantiate(ballTemplateList[randomIndex], new Vector3(position.x, position.y, ballTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea); 
        ball.SetActive(true); 
    
        ballList.Add(ball); 
    } 
}
