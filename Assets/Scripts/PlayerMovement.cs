using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed of the player
    public Rigidbody2D rb; // Reference to the player's Rigidbody2D
    public GameObject shockwavePrefab; // Drag the shockwave prefab here in the Inspector
    public Transform shockwaveSpawnPoint; // The location where the shockwave originates

    private Vector2 movement; // Store movement direction

    void Update()
    {
        // Input for movement
        movement.x = Input.GetAxisRaw("Horizontal"); // Get horizontal movement (A/D or Left/Right arrow)
        movement.y = Input.GetAxisRaw("Vertical");   // Get vertical movement (W/S or Up/Down arrow)

        // When the player presses F, spawn the shockwave
        if (Input.GetKeyDown(KeyCode.F))
        {
            SpawnShockwave();
        }
    }

    void FixedUpdate()
    {
        // Move the player using Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void SpawnShockwave()
    {
        // Instantiate the shockwave at the player's position (or a specific point)
        Instantiate(shockwavePrefab, shockwaveSpawnPoint.position, Quaternion.identity);
    }
}