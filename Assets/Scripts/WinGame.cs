using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{

    

    [SerializeField]
    private GameObject winPanel;

    [SerializeField]
    private GameObject winText;

    [SerializeField]
    private GameObject winCollider;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == winCollider)
        {

            winPanel.SetActive(true);

            winText.SetActive(true);

            Time.timeScale = 0f;


        }


    }




}
