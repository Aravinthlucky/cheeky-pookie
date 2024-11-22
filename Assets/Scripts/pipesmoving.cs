using UnityEngine;

public class PipesMoving : MonoBehaviour
{
    public float speed = 2f; // Initial speed at which the pipes move
    public float leftBound = -10f; // The x-position at which pipes should be destroyed
    private ScoreHandler scoreHandler; // Reference to the ScoreHandler script

    void Start()
    {
        // Find the ScoreHandler instance in the scene
        scoreHandler = FindObjectOfType<ScoreHandler>();
    }

    void Update()
    {
        // Adjust pipe speed based on the current score
        AdjustSpeedBasedOnScore();

        // Move the pipes to the left
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Destroy pipes when they go off-screen
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }

    private void AdjustSpeedBasedOnScore()
    {
        if (scoreHandler.score >= 40)
        {
            speed = 4f; // Faster speed at score 40
        }
        else if (scoreHandler.score >= 20)
        {
            speed = 3f; // Increased speed at score 20
        }
        else
        {
            speed = 2f; // Default speed
        }
    }
}
