using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed=25.0f;
    private float turnSpeed=45.0f;
    private float horizontalInput;
    private float fordwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        fordwardInput = Input.GetAxis("Vertical");

        //Moves the car forward based on vertical input.
        transform.Translate(Vector3.forward*Time.deltaTime*speed* fordwardInput);
        //Rotate de car based on horizontal input.
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput );
        
    }
}
