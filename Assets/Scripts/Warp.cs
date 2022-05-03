using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{

    



    [SerializeField]
    private GameObject start;

    [SerializeField]
    private GameObject start2;

    [SerializeField]
    private GameObject start3;

    [SerializeField]
    private GameObject start4;

    [SerializeField]
    private GameObject end;

    [SerializeField]
    private GameObject end2;

    [SerializeField]
    private GameObject end3;

    [SerializeField]
    private GameObject end4;






    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Alpha1))
        {

            transform.position = end.transform.position;

            rb.velocity = new Vector3(0, 0, 0);

        }


        if (Input.GetKey(KeyCode.Alpha2))
        {

            transform.position = end2.transform.position;

            rb.velocity = new Vector3(0, 0, 0);

        }

        if (Input.GetKey(KeyCode.Alpha3))
        {

            transform.position = end3.transform.position;

            rb.velocity = new Vector3(0, 0, 0);

        }

        if (Input.GetKey(KeyCode.Alpha4))
        {

            transform.position = end4.transform.position;

            rb.velocity = new Vector3(0, 0, 0);

        }

    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject == start)
        {

            rb.velocity = new Vector3(0, 0, 0);

            transform.position = end.transform.position;

        }





        if (other.gameObject == start2)
        {

            transform.position = end2.transform.position;

            rb.velocity = new Vector3(0, 0, 0);

        }

        if (other.gameObject == start3)
        {

            transform.position = end3.transform.position;

            rb.velocity = new Vector3(0, 0, 0);

        }

        if (other.gameObject == start4)
        {

            transform.position = end4.transform.position;

            rb.velocity = new Vector3(0, 0, 0);

        }

    }

    


}
