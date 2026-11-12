
using UnityEngine;

public class PowerSwitch : MonoBehaviour, IInteractable
{
    public SpeakerController speakerController;
    public bool isLeftSpeaker;

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
}

