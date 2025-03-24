using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5.0f;     // Horizontal speed
    public float jumpForce = 8f;       // Jump height
    public float gravity = -9.81f;     // Gravity strength

    private CharacterController controller;
    private Vector3 velocity;          // To store velocity (including gravity)
    private bool isJumping = false;    // To track if the player is in the air

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        MoveCharacter();
        ApplyGravity();
        KeepCharacterOnXAxis();

        // Jumping logic (only when grounded)
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2.0f * gravity); // Apply the jump force
            isJumping = true;
        }
    }

    private void MoveCharacter()
    {
        // Horizontal movement (left-right)
        float moveInput = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(moveInput, 0.0f, 0.0f) * moveSpeed * Time.deltaTime;
        controller.Move(move);
    }

    private void ApplyGravity()
    {
        if (controller.isGrounded)
        {
            // If the character is on the ground, stop vertical movement
            if (velocity.y < 0)
            {
                velocity.y = 0f;  // Prevent the character from moving downward while grounded
                isJumping = false;
            }
        }
        else
        {
            // If the character is in the air, apply gravity
            velocity.y += gravity * Time.deltaTime;
        }

        // Apply the velocity (including gravity or jump force) to the controller
        controller.Move(velocity * Time.deltaTime);
    }

    private void KeepCharacterOnXAxis()
    {
        // Lock the character's movement to the X-axis (preventing movement on the Z-axis)
        Vector3 currentPosition = transform.position;
        currentPosition.z = 0f;  // Zero the Z-axis position
        transform.position = currentPosition;
    }
}
