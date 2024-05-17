using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Credit()
    {
            SceneManager.LoadScene("Credits");
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
