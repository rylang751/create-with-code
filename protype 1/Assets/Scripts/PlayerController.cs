using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public float turnSpeed = 50;
    public float horizontalInput;
    private float verticalInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {    // Axis Setup
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Moves the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Rotate the vehicle left snd right
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
       if(Input.GetKeyDown(switchKey))
        {  mainCamera.enabled = !mainCamera.enabled;
          hoodCamera.enabled = !hoodCamera.enabled;
    }   }  
}
