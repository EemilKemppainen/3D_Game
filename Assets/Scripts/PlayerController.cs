using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject camera1;

    private float moveSpeed = 500;

    private float acceleration = 1;

    [SerializeField]
    private float jumpForce = 20;

    private float jumpCounter;

    private Rigidbody rb;

    public float startX;

    public float startY;

    public Text TextX;

    public Text TextY;

    public Text distanceYText;

    public Text distanceXText;

    public Text SpeedTextX;

    public Text SpeedTextY;

    [SerializeField]
    private GameObject end;

    //[SerializeField]
    //private Transform GroundCheck;

    //[SerializeField]

    //private LayerMask GroundLayer;

    public bool isGrounded;

    private float speed;

    public float distanceY;

    public float distanceX;

    private float moveSpeedX;

    private float moveSpeedY;

    private GameObject spawnPoint;

    //[SerializeField]
    //private GameObject start;

    //[SerializeField]
    //private GameObject end;

    // Start is called before the first frame update
    void Start()
    {

        spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");

        //rb.velocity = new Vector3(0, 0, 0);

        Vector2 startPos = Input.mousePosition;

        startX = startPos.x;

        startY = startPos.y;

        rb = GetComponent<Rigidbody>();

        

    }

    // Update is called once per frame
    void Update()
    {

        

        //isGrounded = Physics.CheckSphere(GroundCheck.position, 0.4f, GroundLayer);


        Vector2 middle = new Vector2(612.75f, 347.375f);

        Vector2 mousePos = Input.mousePosition;

        float x = mousePos.x;

        float y = mousePos.y;


        Vector2 mouseDistanceY = new Vector2(middle.x, mousePos.y);

        Vector2 mouseDistanceX = new Vector2(mousePos.x, middle.y);

        distanceY = Vector2.Distance(mouseDistanceY, middle);

        distanceX = Vector2.Distance(mouseDistanceX, middle);

        TextY.text = "Y:" + mousePos.y;

        TextX.text = "X:" + mousePos.x;

        distanceYText.text = "Distance" + distanceY;

        distanceXText.text = "Distance" + distanceX;

        moveSpeedX = distanceX * 10;

        moveSpeedY = distanceY * 20;

        SpeedTextX.text = "Speed" + moveSpeedX;

        SpeedTextY.text = "Speed" + moveSpeedY;

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {

            


                rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);

                isGrounded = false;

            
            
        }

        if (isGrounded == false)
        {

            rb.AddForce(Vector3.down * 20, ForceMode.Acceleration);

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {

            rb.AddForce(camera1.transform.forward * 5000 * Time.deltaTime , ForceMode.VelocityChange);

        }





        
        //if (Input.GetKey(KeyCode.W))
        //{
                
            //rb.AddForce(camera1.transform.forward * moveSpeed * Time.deltaTime, ForceMode.Acceleration);
        
        //}


        //float verticalInput = Input.GetAxis("Mouse Y");
        //rb.AddForce(camera1.transform.forward * verticalInput * moveSpeed * Time.deltaTime, ForceMode.Acceleration);


        //float horizontalInput = Input.GetAxis("Mouse X");
        //rb.AddForce(camera1.transform.right * horizontalInput * moveSpeed * Time.deltaTime, ForceMode.Acceleration);

        speed = y * 5  ;

        //25
        //15

        if (isGrounded && Input.GetMouseButton(0))
        {

            if (y > 347.375)
            {



                rb.AddForce(camera1.transform.forward * distanceY * 55 * Time.deltaTime);


                acceleration = acceleration + 0.005f;

            }

            else if (y < 346.125)
            {

                rb.AddForce(-camera1.transform.forward * distanceY * 55 * Time.deltaTime);


                acceleration = acceleration + 0.005f;


            }

            if (x > 612.75)
            {



                rb.AddForce(camera1.transform.right * distanceX * 45 * Time.deltaTime);


                acceleration = acceleration + 0.005f;

            }

            else if (x < 612.75)
            {

                rb.AddForce(-camera1.transform.right * distanceX * 45 * Time.deltaTime);


                acceleration = acceleration + 0.005f;


            }



            else
            {

                acceleration = 1;

            }


        }

            if (transform.position.y < -7)
            {

                transform.position = spawnPoint.transform.position;

                rb.velocity = new Vector3(0, 0, 0);



            }

        


    }

    private void OnCollisionEnter(Collision other)
    {

        

        if (other.gameObject.CompareTag("Ground"))
        {

            isGrounded = true;


        }

        

        



    }

    private void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {

            isGrounded = false;

        }


    
    }

    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {

            isGrounded = true;

        }

    }










}
