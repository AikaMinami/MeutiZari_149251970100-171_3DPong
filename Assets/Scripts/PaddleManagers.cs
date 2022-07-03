using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleManagers : MonoBehaviour
{
    public int speed; 
    public KeyCode leftKey; 
    public KeyCode rightKey; 
    public KeyCode forwardKey; 
    public KeyCode backKey; 
    private Rigidbody rig; 
    private float magnitudes;
    void Start()
    {
        rig = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());  
        // Debug.Log("Paddle Speed: " + rig.velocity); 
    }

    private Vector3 GetInput() 
    { 
       if (Input.GetKey(leftKey) )
        { 
            return Vector3.left * speed; 
        } 
        else if (Input.GetKey(rightKey) )
        { 
            return Vector3.right * speed; 
        } else if (Input.GetKey(forwardKey) )
        { 
            return Vector3.forward * speed; 
        } 
        else if (Input.GetKey(backKey) )
        { 
            return Vector3.back * speed; 
        } 
         
        return Vector3.zero; 
    } 

    private void MoveObject(Vector3 movement) 
    { 
        rig.velocity = movement; 
    } 

    public void MoveObjectDefault() 
    { 
        MoveObject(GetInput());  
    } 
}
