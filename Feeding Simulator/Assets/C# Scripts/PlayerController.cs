using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 15.0f;

    public GameObject projectilePrefab; // making sure the player always has a reference to that piece of pizza
    /*
    - a Prefab is a Prefabricated version of the object that you're using.
      we want to reuse the piece of pizza in this case. (it will always have the "Move Forward script" applied to it and the size of the pizza)
      meaning that it stores all the previous tweeks that you've made with the GameObject.
      (must click "Original Prefab" !!!)
    - the blue cube on the side means that it's a Prefab.
    */

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.x < -xRange) //we want to make sure that the player doesn't leave the grass, so this is left boundary.
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); // making sure that the player keeps itself in -10 but still keep the other positions(y,z).
        }

        if (transform.position.x > xRange) //we want to make sure that the player doesn't leave the grass, so this is right boundary.
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); // making sure that the player keeps itself in 10 but still keep the other positions(y,z).
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            /*
            - GetKeyDown : whenever the key is pressed down specifically.
                           whenever the player presses the key down once, it'll fire off one of our projectiles.
            - GetKeyUp : whenever you let go of that key it will do that thing.
            - KeyCode : can let you choose any key on the keyboard.
            */
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            /*
            meaning for line above:
            Instantiate(Object original, Vector3 position, Quatemion rotation)
            Instantiate(Object to copy, position that object is going to start at , rotation it should be when you create it)
                                        (player's position in our case)             (we already have it in our prefab and we are only going in one postion in our case)
            - Quatemion : 四元數
            - Instantiate : another way of saying that we're going to Create an Object.
             (In our case)  is for creating copies of Objects that already exist. ex. our "projectilePrefab" that we created on the top.
                                                                                     just trying to create copies of "projectilePrefab"s, not new ones.
            
            */

        }
    }
}
