using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

interface IInteractable
{
    public void Interact();
}

public class Interactor : MonoBehaviour
{

public Transform InteractionSource;
public float InteractionRange;   

 void Start() {
        
    }

    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            Ray r = new Ray(InteractionSource.position, InteractionSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractionRange)) {
                if(hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)) {
                    interactObj.Interact();
                }     
            }
        }
    }
}
