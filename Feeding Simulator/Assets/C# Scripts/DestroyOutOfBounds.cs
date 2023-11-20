using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30; //for the pizza
    private float lowerBoundary = -10; //for the animals
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If an object goes past the players view in the game, remove that object
        /*
        we created this because we want to destroy the pizzas that we threw so it doesnt break our game.
        rn our game cannot destroy the pizzas we are throwing with the space bar.
        */
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject); //pizza
        }
        else if(transform.position.z < lowerBoundary)
        {
            Debug.Log("Game Over!"); // if an animal passes the player it will show "Game Over!"
            Destroy(gameObject); //animal
        }
    }
}
