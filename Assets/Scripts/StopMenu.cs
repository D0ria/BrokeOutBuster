using UnityEngine;

public class StopMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    private bool isPaused = false;

    public void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    public void Update()
    {
       // Debug.Log(PlayerMovement.instance);
        if (PlayerMovement.instance.inputActions.Player.Menu.IsPressed())
        {
            
            
                Pause();
        }
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f; 
        pauseMenuUI.SetActive(isPaused); 
    }

    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1f; 
        pauseMenuUI.SetActive(isPaused); 
    }

    public void QuitGame()
    {
        Application.Quit(); 
    }
}
