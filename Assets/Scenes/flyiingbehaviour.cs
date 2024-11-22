using UnityEngine;

public class FlyingBehaviour : MonoBehaviour
{
    public float flapForce = 5f; // Force applied when the bird flaps
    public float gravityScale = 1f; // Gravity scale for the bird
    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component attached to the bird
        rb = GetComponent<Rigidbody2D>();

        // Apply gravity scale to the Rigidbody2D
        rb.gravityScale = gravityScale;
    }

    void Update()
    {
        // Check for input (e.g., space bar or mouse click)
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            // Apply an upward force for the "flap"
            rb.velocity = Vector2.up * flapForce;
        }
    }
}
