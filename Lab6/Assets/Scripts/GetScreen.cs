using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetScreen : MonoBehaviour
{
    private string sceneName = "SampleScene"; // Initial scene name
    private screenSwitch screenSwitchScript;

    void Start()
    {
        // Find and cache the screenSwitch component in the scene
        screenSwitchScript = FindObjectOfType<screenSwitch>();

        if (screenSwitchScript == null)
        {
            Debug.LogError("screenSwitch component not found in the scene.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Toggle scene name
            if (sceneName == "SampleScene")
            {
                sceneName = "Demo";
            }
            else
            {
                sceneName = "SampleScene";
            }

            Debug.Log("Switching to " + sceneName + " Scene");

            // Call screenSwitch to change scene
            if (screenSwitchScript != null)
            {
                screenSwitchScript.screenChanger(sceneName);
            }
        }
    }
}
