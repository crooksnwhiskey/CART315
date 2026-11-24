using UnityEngine;
using Cart315.FirstPerson;

[DisallowMultipleComponent]
[RequireComponent(typeof(FPInputManager))]
public class MouseLook : MonoBehaviour
{
    [Tooltip("Reference to the camera holder game object")]
    [SerializeField] private Transform _cameraHolderTransform;

    [Tooltip("Mouse sensitivity, degrees turned per pixel of mouse movement")]
    [SerializeField][Range(0.01f, 0.5f)] private float _mouseSensitivity = 0.05f;

    [Tooltip("How far the camera can look up and down, in degrees")]
    [SerializeField][Range(0, 90)] private float _maxCameraY = 90f;

    private FPInputManager _input;
    private Vector2 _lookDirection;

    private void Awake()
    {
        _input = GetComponent<FPInputManager>();
    }

    private void Start()
    {
        _lookDirection.x = transform.localEulerAngles.y;
        if (_cameraHolderTransform == null)
        {
            Debug.LogError("Assign the player's Camera Pivot to Camera Holder Transform.", this);
            enabled = false;
            return;
        }
        _lookDirection.y = -Mathf.DeltaAngle(0, _cameraHolderTransform.localEulerAngles.x);
    }

    private void Update()
    {
        _input.ReadInput(); 
    }

    private void LateUpdate()
    {
        _lookDirection += new Vector2(_input.LookInput.x * _mouseSensitivity, _input.LookInput.y * _mouseSensitivity);
        _lookDirection.y = Mathf.Clamp(_lookDirection.y, -_maxCameraY, _maxCameraY);
        _cameraHolderTransform.localRotation = Quaternion.Euler(-_lookDirection.y, 0, 0);
        transform.localRotation = Quaternion.Euler(0, _lookDirection.x, 0);
    }

    private void OnDisable()
    {
        if (_input != null) _input.ReleaseCursor();
    }
}