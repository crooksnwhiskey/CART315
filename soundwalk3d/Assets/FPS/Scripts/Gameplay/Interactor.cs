using UnityEngine.InputSystem;
using UnityEngine;

interface IInteractable
{
    public void Interact();
    public void OnHover();
    public void OnHoverExit();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractionSource;
    public float InteractionRange;

    private IInteractable currentInteractable;

    void Update()
    {
        Ray r = new Ray(InteractionSource.position, InteractionSource.forward);

        IInteractable newInteractable = null;

        if (Physics.Raycast(r, out RaycastHit hitInfo, InteractionRange))
        {
            hitInfo.collider.gameObject.TryGetComponent(out newInteractable);
        }

        if (newInteractable != currentInteractable)
        {
            if (currentInteractable != null)
            {
                currentInteractable.OnHoverExit();
            }

            currentInteractable = newInteractable;

            if (currentInteractable != null)
            {
                currentInteractable.OnHover();
            }
        }

        if (Keyboard.current.eKey.wasPressedThisFrame && currentInteractable != null)
        {
            currentInteractable.Interact();
        }
    }
}