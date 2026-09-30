using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController1 : MonoBehaviour
{
    private Vector2 _direction;

    public Paddle paddle;

    private void Update()
    {
        _direction = Vector2.zero;

        if (Keyboard.current[Key.UpArrow].isPressed)
            _direction = Vector2.up;
        else if (Keyboard.current[Key.DownArrow].isPressed)
            _direction = Vector2.down;

        paddle.direction = _direction;

        if (Keyboard.current[Key.LeftArrow].isPressed)
            paddle.transform.Rotate(Vector3.forward * paddle.rotationSpeed * Time.deltaTime);
        else if (Keyboard.current[Key.RightArrow].isPressed)
            paddle.transform.Rotate(Vector3.back * paddle.rotationSpeed * Time.deltaTime);
    }
}