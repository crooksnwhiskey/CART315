using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector2 _direction;

    public Paddle paddle;

    // Update is called once per frame
    private void Update()
    {
        _direction = Vector2.zero;

        if (Keyboard.current.wKey.isPressed)
            _direction = Vector2.up;
        else if (Keyboard.current.sKey.isPressed)
            _direction = Vector2.down;

        paddle.direction = _direction;

        if (Keyboard.current.aKey.isPressed)
            paddle.transform.Rotate(Vector3.forward * paddle.rotationSpeed * Time.deltaTime);
        else if (Keyboard.current.dKey.isPressed)
            paddle.transform.Rotate(Vector3.back * paddle.rotationSpeed * Time.deltaTime);
    }
}