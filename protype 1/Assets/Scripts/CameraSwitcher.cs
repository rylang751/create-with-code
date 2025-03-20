using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // Start is called before the first frame update

     public Camera[] cameras;  // Array to hold all the cameras
    private int currentCameraIndex = 0;  // Index to track the current camera
    void Start()
    {
         // Initially disable all cameras except the first one
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }
        // Enable the first camera by default
          if (cameras.Length > 0)
          {
            cameras[currentCameraIndex].gameObject.SetActive(true);
          }

    }

    // Update is called once per frame
    void Update()
    {
        // Switch cameras on key press (e.g., "C" key)
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
        
        void SwitchCamera()
       {
        // Disable the current camera
        cameras[currentCameraIndex].gameObject.SetActive(false);

          // Increment the camera index, wrap around if necessary
        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

          // Enable the new camera
        cameras[currentCameraIndex].gameObject.SetActive(true);

       }
    
    }
}
