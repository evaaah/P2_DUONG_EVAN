using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamite : MonoBehaviour
{
    private GameManager gameManager;
    public int pointValue;

    void Start()
    {
       
    }

    // Destroys dynamite after going below -5 on Y axis
    void Update()
    {
         if (transform.position.y < -5) 
         {
            Destroy(gameObject);
         }
    }  

    // Update score by 5 points when dynamite reaches -5 on Y axis
  private void OnMouseDown()
    {
        if(gameManager.isGameActive)
        {
            gameManager.UpdateScore(pointValue);
        }
    }
}