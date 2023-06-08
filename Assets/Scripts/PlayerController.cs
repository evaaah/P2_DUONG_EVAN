using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4.0f;
    public bool gameOver = false;

// Moves sphere   
void FixedUpdate()
    {
        float HorizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");
        Vector3 MoveBall = new Vector3(HorizontalMovement,0,VerticalMovement);
        gameObject.transform.GetComponent<Rigidbody>().AddForce(MoveBall);
    }

    // Player loses when reaching -5 on Y axis
    void Update()
    {
         if (transform.position.y < -5) 
         {
            Destroy(gameObject);
            Debug.Log("Game Over!");
            gameOver = true;
         }
    }  
}