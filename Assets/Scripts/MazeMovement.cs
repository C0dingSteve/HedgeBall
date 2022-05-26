using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMovement : MonoBehaviour
{
    // variables
    public float tiltSpeed = 15.0f;
    private float tiltInputY;
    private float tiltInputX; 

    void Start()
    {
        
    }

    void Update()
    {
        // set tilting input from Unity's input manager
        tiltInputY = Input.GetAxis("Vertical");
        tiltInputX = Input.GetAxis("Horizontal");

        // maze tilting movement on "Y" & "X" axis
        transform.Rotate(Vector3.forward, tiltSpeed * Time.deltaTime * tiltInputY);
        transform.Rotate(Vector3.right, tiltSpeed * Time.deltaTime * tiltInputX);
    }
}
