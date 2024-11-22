using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab; // The pipe prefab to spawn
    public float spawnInterval = 2f; // Time interval between pipe spawns
    public float spawnHeightRange = 1f; // Height variation for spawning pipes
    public float startDelay = 1f; // Initial delay before spawning starts

    private void Start()
    {
        // Start spawning pipes at regular intervals
        InvokeRepeating(nameof(SpawnPipe), startDelay, spawnInterval);
    }

    private void SpawnPipe()
    {
        // Randomize the vertical position of the pipe
        float randomHeight = Random.Range(-spawnHeightRange, spawnHeightRange);

        // Create a new pipe at the spawner's position with a random height offset
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + randomHeight, transform.position.z);
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}
