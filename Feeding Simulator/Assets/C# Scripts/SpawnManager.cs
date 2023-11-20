using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    /*
    - creating an array: to store multiple objects.
    - meaning of the line above : we have created a public GameObject array of animalPrefabs.
    */
    //public int animalIndex; //when you don't give it a sum, it's automatically 0
    private float spawnRangeX = 15;
    private float spawnPositionZ = 20; //setting these variables makes our lives better, we can always just change them from here if needed to.
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        /*
        - InvokeRepeating : it will take a method that we want to call, and at a certain time, we'll start to call that method, 
                            and then constantly repeat it over time depending on whatever rate we want.
        InvokeRepeating("a string: name of the method we're using", time to start at, time to repeat every single time)
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal() // creating this just makes code look cleaner
    {
        //Randomly generate animal index and spawn position

    int animalIndex = Random.Range(0, animalPrefabs.Length); //getting a random index(0 , 1 , 2) from the array
        /*
        you're setting a random to animalIndex so it would go 0.1.2 either one.
        we set animalPrefabs.Length cause it can tell how many animalPrefabs there are.
        */
    Vector3 spawnPosition =  new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ); // placing it in a random position
        // we don't have a "y" in this case cause we don't want it to fly.
            
    Instantiate(animalPrefabs[animalIndex],spawnPosition, animalPrefabs[animalIndex].transform.rotation); // actually create the animal
        //Instantiate(Object to copy, position that object is going to start at , rotation it should be when you create it)
    }
}
