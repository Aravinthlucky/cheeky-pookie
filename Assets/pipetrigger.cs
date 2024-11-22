using UnityEngine;

public class PipeTrigger : MonoBehaviour
{
    private ScoreHandler scoreHandler;

    private void Start()
    {
        // Find the ScoreHandler in the scene
        scoreHandler = FindObjectOfType<ScoreHandler>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the bird passed through the trigger
        if (other.CompareTag("Bird"))
        {
            scoreHandler.AddScore();
        }
    }
}
