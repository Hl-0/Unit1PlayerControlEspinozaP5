using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 0.02f;
    private float turnSpeed = 10;
    private float horizontalInput;
    private float forwardInput;
    public Camera mainCamera;
    public Camera HoodCamera;
    public KeyCode switchKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // move the car forward based on vertcial input
        transform.Translate(Vector3.forward * speed * forwardInput);
        //Rotatess the car bassed on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            mainCamera.enabled = !HoodCamera.enabled;
        }
        
    }
}
