using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    public Text scoreText;  // UI Text to display the score
    public int score = 0;   // Current score
    public int winScore = 10; // Score needed to win

    private GameManager gameManager;

    void Start()
    {
        // Reference the GameManager in the scene
        gameManager = FindObjectOfType<GameManager>();
    }

    // Method to increase the score
    public void AddScore()
    {
        score++;
        UpdateScoreDisplay();

        // Check if the player has reached the win score
        if (score >= winScore)
        {
            gameManager.GameWon(); // Notify the GameManager
        }
    }

    // Method to update the score display
    public void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score;
    }
}
