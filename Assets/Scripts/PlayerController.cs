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

    private bool canJump;

    private float speed;

    public float distanceY;

    public float distanceX;

    private float moveSpeedX;

    private float moveSpeedY;

    private GameObject spawnPoint;

    float screenWidth = UnityEngine.Screen.width;

    float screenHeight = UnityEngine.Screen.height;

    private float playerY;

    public Text playerYText;

    [SerializeField]
    private float offSetX;

    [SerializeField]
    private float offSetY;


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
        
        playerY = transform.position.y;

        playerYText.text = "Y" + playerY;

        float middleX = screenWidth / 2;

        float middleY = screenHeight / 2;

        //612.75f, 374.375f

        Vector2 middle = new Vector2(middleX, middleY);

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

        moveSpeedX = distanceX * 55;

        moveSpeedY = distanceY * 55;

        SpeedTextX.text = "Speed" + moveSpeedX;

        SpeedTextY.text = "Speed" + moveSpeedY;

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {


                rb.AddForce(Vector3.up * 20 , ForceMode.Impulse);

                //rb.velocity = new Vector3(rb.velocity.x, 1000 * Time.deltaTime, rb.velocity.z);

                isGrounded = false;

                canJump = false;
            
        }

        if (isGrounded == false)
        {

            rb.AddForce(Vector3.down * 1000 * Time.deltaTime, ForceMode.Acceleration);

        }

        //if (Input.GetKeyDown(KeyCode.Q))
        //{

        //    rb.AddForce(camera1.transform.forward * 5000 * Time.deltaTime , ForceMode.VelocityChange);

        //}





        
        //if (Input.GetKey(KeyCode.W))
        //{
                
            //rb.AddForce(camera1.transform.forward * moveSpeed * Time.deltaTime, ForceMode.Acceleration);
        
        //}


        //float verticalInput = Input.GetAxis("Mouse Y");
        //rb.AddForce(camera1.transform.forward * verticalInput * moveSpeed * Time.deltaTime, ForceMode.Acceleration);


        //float horizontalInput = Input.GetAxis("Mouse X");
        //rb.AddForce(camera1.transform.right * horizontalInput * moveSpeed * Time.deltaTime, ForceMode.Acceleration);

        

        //25
        //15

        if (isGrounded)
        {

            if (y > middleY + offSetY)
            {



                rb.AddForce(camera1.transform.forward * distanceY * 55 * Time.deltaTime);


                acceleration = acceleration + 0.005f;

            }

            else if (y < middleY - offSetY)
            {

                rb.AddForce(-camera1.transform.forward * distanceY * 55 * Time.deltaTime);


                acceleration = acceleration + 0.005f;


            }

            if (x > middleX + offSetX)
            {



                rb.AddForce(camera1.transform.right * distanceX * 55 * Time.deltaTime);


                acceleration = acceleration + 0.005f;

            }

            else if (x < middleX - offSetX)
            {

                rb.AddForce(-camera1.transform.right * distanceX * 55 * Time.deltaTime);


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

                Cursor.lockState = CursorLockMode.Locked;

                //transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

            }

        


    }

    private void OnCollisionEnter(Collision other)
    {

        

        if (other.gameObject.CompareTag("Ground"))
        {

            isGrounded = true;


        }

        if (other.gameObject.CompareTag("JumpGround"))
        {

            canJump = true;

            isGrounded = true;

        }





    }

    private void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {

            isGrounded = false;

        }


        if (collision.gameObject.CompareTag("JumpGround"))
        {

            canJump = false;

            isGrounded = false;

        }

    }

    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {

            isGrounded = true;

        }


        if (collision.gameObject.CompareTag("JumpGround"))
        {

            canJump = true;

            isGrounded = true;

        }


    }


    






}
