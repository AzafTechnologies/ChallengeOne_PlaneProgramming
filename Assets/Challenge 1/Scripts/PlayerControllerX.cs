using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    public InputAction moveAction;

    public Vector2 moveInput;



    // Start is called before the first frame update
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = moveAction.ReadValue<Vector2>();
       

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime );

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * moveInput.y);
    }
}
