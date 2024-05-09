using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        // Check for the "P" key press
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Toggle between paused and unpaused state
            if (!isPaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    void Pause()
    {
        Time.timeScale = 0f; // Set time scale to 0 to pause the game
        isPaused = true;
        Debug.Log("Game paused");
    }

    void Resume()
    {
        Time.timeScale = 1f; // Set time scale back to 1 to resume the game
        isPaused = false;
        Debug.Log("Game resumed");
    }
}