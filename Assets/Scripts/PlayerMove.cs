using UnityEngine;
using UnityEngine.InputSystem;

public class Playermove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 move = Vector2.zero;

        if (Keyboard.current.aKey.isPressed) move.x -= 1f;
        if (Keyboard.current.dKey.isPressed) move.x += 1f;

        rb.linearVelocity = new Vector2(move.x * moveSpeed, rb.linearVelocity.y);
    }
}
