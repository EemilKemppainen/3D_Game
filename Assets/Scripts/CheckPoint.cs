using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    [SerializeField]
    private GameObject spawnPoint;

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

    // Start is called before the first frame update
    void Start()
    {

        spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == start)
        {

            spawnPoint.transform.position = end.transform.position;


        }

        if (other.gameObject == start2)
        {

            spawnPoint.transform.position = end2.transform.position;


        }

        if (other.gameObject == start3)
        {

            spawnPoint.transform.position = end3.transform.position;


        }

        if (other.gameObject == start4)
        {

            spawnPoint.transform.position = end4.transform.position;


        }

    }

       
    




}
