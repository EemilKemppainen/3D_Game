using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{

    [SerializeField]
    private GameObject start;

    [SerializeField]
    private GameObject end;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject == start)
        {

            transform.position = end.transform.position;

            rb.velocity = new Vector3(0, 0, 0);

        }

    }

    


}
