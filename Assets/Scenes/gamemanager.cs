using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startMenuCanvas;   // Reference to the Start Menu canvas
    public GameObject gameOverCanvas;   // Reference to the Game Over canvas
    public GameObject gameWonCanvas;    // Reference to the Game Won canvas
    public int nextLevelIndex;          // Build Index of the next level

    void Start()
    {
        // Initialize the UI states
        startMenuCanvas?.SetActive(true);
        gameOverCanvas?.SetActive(false);
        gameWonCanvas?.SetActive(false);

        // Pause the game at the start
        Time.timeScale = 0;
    }

    // Function to start the game
    public void StartGame()
    {
        // Hide the Start Menu canvas and resume the game
        if (startMenuCanvas != null)
            startMenuCanvas.SetActive(false);

        Time.timeScale = 1;
    }

    // Function to be called when the game is over
    public void GameOver()
    {
        // Show the Game Over canvas and pause the game
        if (gameOverCanvas != null)
            gameOverCanvas.SetActive(true);

        Time.timeScale = 0;
    }

    // Function to be called when the player wins the game
    public void GameWon()
    {
        // Show the Game Won panel and pause the game
        if (gameWonCanvas != null)
            gameWonCanvas.SetActive(true);

        Time.timeScale = 0;
    }

    // Function to restart the game
    public void RestartGame()
    {
        // Reset time scale to 1 and reload the current scene
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Function to load the next level
    public void LoadNextLevel()
    {
        // Resume the game and load the next level
        Time.timeScale = 1;
        SceneManager.LoadScene(nextLevelIndex);
    }

    // Function to quit the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
