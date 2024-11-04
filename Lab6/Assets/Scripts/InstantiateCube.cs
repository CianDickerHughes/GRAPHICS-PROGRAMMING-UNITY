using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCube : MonoBehaviour
{
    public GameObject cubePrefab; // Reference to the cube prefab

    void Update()
    {
        // Check if Spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate a new cube at a random position
            Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), 1, Random.Range(-5f, 5f));
            Instantiate(cubePrefab, randomPosition, Quaternion.identity);
        }
    }
}
