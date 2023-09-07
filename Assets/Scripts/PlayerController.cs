using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // private variables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get directions from player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");



        // Move the vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Turn the vehicle sideways
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }

    /*
    public void Forward()
    {
        int forwardMove = 1;
        forwardMove += 1;
        // Move the vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardMove);
    }
    public void Downward()
    {
        int backwardMove = 0;
        backwardMove -= 1;
        // Move the vehicle backward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * backwardMove);
    }
    public void Left()
    {
        int leftMove = 0;
        leftMove -= 1;
        // Turn vehicle left
        transform.Rotate(Vector3.up * Time.deltaTime * speed * leftMove);
    }
    public void Right()
    {
        int rightMove = 1;
        rightMove += 1;
        // Turn vehicle right
        transform.Rotate(Vector3.up * Time.deltaTime * speed * rightMove);
    }

    public void StopMove()
    {
        int stopMove = 0;

        // Stop the vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * speed * stopMove);
    }
    public void SpinMove()
    {
        int spinMove = 360;

        // Stop the vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * speed * spinMove);
    }
    */


}
