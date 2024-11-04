using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetScreen : MonoBehaviour
{
    private string currentSceneName; // Current active scene name
    private screenSwitch screenSwitchScript;

    void Start()
    {
        // Get the name of the current active scene
        currentSceneName = SceneManager.GetActiveScene().name;

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
            // Determine the next scene based on the current scene
            string nextSceneName = (currentSceneName == "SampleScene") ? "Demo" : "SampleScene";

            Debug.Log("Switching to " + nextSceneName + " Scene");

            // Call screenSwitch to change scene
            if (screenSwitchScript != null)
            {
                screenSwitchScript.screenChanger(nextSceneName);
            }

            // Update the currentSceneName to reflect the newly loaded scene
            currentSceneName = nextSceneName;
        }
    }
}
