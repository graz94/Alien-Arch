using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementScript : MonoBehaviour
{
    //Reference variable so we can use the Rigidbody
    //Set it to null by default, which means we do NOT have a reference yet
    private Rigidbody2D physicsBody = null;
    
    public Collider2D groundSensor = null;
    public LayerMask groundLayer = 0;
    public float jumpSpeed = 10;
    public void MoveLeft()
    {
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.x = -5;
        physicsBody.velocity = newVelocity;
    }
    public void MoveRight()
    {
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.x = 5;
        physicsBody.velocity = newVelocity;
    }
    
    public void Jump()
    {
        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            // Make a variable to hold our velocity and get the current velocity from the physics component
            Vector2 newVelocity = physicsBody.velocity;
            // Set our velocity to move in the positive y (up) direction
            newVelocity.y = jumpSpeed;
            // Update our component's velocity to be our newly changed value
            physicsBody.velocity = newVelocity;
        }
    }
    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
