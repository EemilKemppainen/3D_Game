using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    private float mouseTurnSpeed = 1000f;

    private float turnSpeed = 500f;

    public GameObject player;

    private float X;
    
    private float Y;



    // Start is called before the first frame update
    void Awake()
    {

        Cursor.lockState = CursorLockMode.Locked;

        


    }





    // Update is called once per frame
    void Update()
    {
        


        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);

        //float verticalInput = Input.GetAxis("Vertical");
        //transform.Rotate(Vector3.right, verticalInput * turnSpeed * Time.deltaTime);

        transform.position = player.transform.position;


        //if (Input.GetMouseButton(2))
        {
            //transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * turnSpeed, -Input.GetAxis("Mouse X") * turnSpeed, 0));
            //X = transform.rotation.eulerAngles.x;
            //Y = transform.rotation.eulerAngles.y;
            //transform.rotation = Quaternion.Euler(X, Y, 0);
        }

        if (Input.GetMouseButton(2) || Input.GetMouseButton(1))
        {

            Cursor.lockState = CursorLockMode.Locked;

            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * mouseTurnSpeed * Time.deltaTime, 0));

        }

        else
        {
            Cursor.lockState = CursorLockMode.Confined;
        }





    }
}
