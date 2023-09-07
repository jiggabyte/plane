using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameExtraController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject vehicle;

    // private variables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;


    private bool extraButtonHeld = false; // Flag to track if the button is held down

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnPointerDown(PointerEventData eventData)
    {
        // This method is called when the button is initially pressed

        extraButtonHeld = true;


        InvokeRepeating("SpinMove", 0f, 0.1f);



    }

    public void OnPointerUp(PointerEventData eventData)
    {

        // This method is called when the button is initially pressed

        extraButtonHeld = false;

        CancelInvoke("SpinMove");



    }

    public void SpinMove()
    {
        int spinMove = 360;

        // Stop the vehicle
        vehicle.transform.Rotate(Vector3.up * Time.deltaTime * speed * spinMove);
    }


}
