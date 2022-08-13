using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject startButton;

    public GameObject quitButton;

    public GameObject text;

    public GameObject playButton;

    public GameObject note;

    // Start is called before the first frame update
    void Start()
    {
     
        

    }

    // Update is called once per frame
    void Update()
    {

            



    }

    public void Play()
    {

        startButton.SetActive(false);

        quitButton.SetActive(false);

        text.SetActive(true);

        playButton.SetActive(true);

        note.SetActive(true);


    }

    public void StartGame()
    {

        SceneManager.LoadScene(1);

        Cursor.lockState = CursorLockMode.Locked;


    }


    public void Quit()
    {

        Application.Quit();

    }






}
