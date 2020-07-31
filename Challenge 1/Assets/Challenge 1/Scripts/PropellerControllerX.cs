using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerControllerX : MonoBehaviour
{
    // Private variables
    private float rotationSpeed = 150.0f;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Get user's left/right input
        horizontalInput = Input.GetAxis("Horizontal");

        // Rotate the propellar at const speed when user moves the plane
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed * horizontalInput);
    }
}
