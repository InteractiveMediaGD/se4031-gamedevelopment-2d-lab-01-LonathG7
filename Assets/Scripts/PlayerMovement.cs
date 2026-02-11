using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Get input from Arrow keys or WASD
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Apply movement
        transform.position += new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime;
    }
}