using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseGame : MonoBehaviour
{

    private bool gameIsPaused = false;

    public GameObject continueButton;

    public GameObject mainMenuButton;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P) && gameIsPaused == false)
        {

            continueButton.SetActive(true);

            mainMenuButton.SetActive(true);

            gameIsPaused = true;

            Time.timeScale = 0f;

        }

        else if (Input.GetKeyDown(KeyCode.P))
        {

            continueButton.SetActive(false);

            mainMenuButton.SetActive(false);

            gameIsPaused = false;

            Time.timeScale = 1f;

        }






    }

    public void ContinueGame()
    {

        

        Time.timeScale = 1f;

        continueButton.SetActive(false);

        mainMenuButton.SetActive(false);

        gameIsPaused = false;

        Cursor.lockState = CursorLockMode.Locked;


    }

    public void MainMenu()
    {

        Time.timeScale = 1f;

        SceneManager.LoadScene(0);


    }



}
