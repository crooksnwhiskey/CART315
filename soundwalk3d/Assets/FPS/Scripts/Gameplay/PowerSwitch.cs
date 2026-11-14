
using UnityEngine;

public class PowerSwitch : MonoBehaviour, IInteractable
{
    public SpeakerController speakerController;
    public bool isLeftSpeaker;
    public ObjectOutline outline;

    public void Interact()
    {
        if (isLeftSpeaker)
        {
            speakerController.ToggleLeftSpeaker();
        }
        else
        {
            speakerController.ToggleRightSpeaker();
        }
    }
    public void OnHover()
    {
        outline.EnableOutline();
    }
    public void OnHoverExit()
    {
        outline.DisableOutline();
    }
}

