                using UnityEngine;

public class InputResiver : MonoBehaviour
{ 
    public bool JumpPresed { get; private set; }
    public Vector2 Move { get; private set; }
    public bool AtackPressed { get; private set; }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Move = new Vector2(horizontalInput, 0);

        JumpPresed = Input.GetKeyDown(KeyCode.W);

        AtackPressed = Input.GetMouseButtonDown(0);
    }
}
