using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("UpArrow key was pressed.");
            transform.Translate(Vector3.forward * 1);       
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("DownArrow key was pressed.");
            transform.Translate(Vector3.back * 1);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("RightArrow key was pressed.");
            transform.Translate(Vector3.right * 1);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("LeftArrow key was pressed.");
            transform.Translate(Vector3.left * 1);

        }
    }
}
