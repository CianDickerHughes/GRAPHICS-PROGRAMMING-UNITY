using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; // Assign in Inspector
    private Vector3 offset;
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Start is called before the first frame update
   void Start()
{
    if (player == null)
    {
        Debug.LogError("Player reference is not assigned in CameraController!");
    }
    else
    {
        offset = transform.position - player.transform.position;
    }
}

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            transform.position = player.transform.position + offset;
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }
}
