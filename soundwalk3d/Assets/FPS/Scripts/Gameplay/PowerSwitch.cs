using UnityEngine;

public class PowerSwitch : MonoBehaviour, IInteractable
{
public SpeakerController speakerController;

    public void Interact()
    {
      
        speakerController.ToggleSpeaker();
    }
}
