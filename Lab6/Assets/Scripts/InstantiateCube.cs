using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCube : MonoBehaviour
{
    public GameObject cubePrefab; // Reference to the cube prefab
     void Start()
    {
        
    }

    void Update()
    {
        // Check if Spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate a new cube at a random position
           Instantiate(cubePrefab, new Vector3(2, 2, 2), Quaternion.identity);
        }
    }
}
