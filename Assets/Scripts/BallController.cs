using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed; 
    private Rigidbody rig; 
    public Vector3 resetPosition; 

    void Start()
    {
        rig = GetComponent<Rigidbody>(); 
        rig.velocity = speed; 
    } 

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(speed * Time.deltaTime); 
    }

    public void ResetBall() 
    { 
        transform.position = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z); 
    } 

    
}
