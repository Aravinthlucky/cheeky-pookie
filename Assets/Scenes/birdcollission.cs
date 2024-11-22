using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    public GameManager gameManager; // Reference to the GameManager script

    void Start()
    {
        // Ensure the GameManager reference is set
        if (gameManager == null)
        {
            gameManager = FindObjectOfType<GameManager>();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Ground"))
        {
            // Call the GameOver function in the GameManager
            gameManager.GameOver();
        }
    }
}
