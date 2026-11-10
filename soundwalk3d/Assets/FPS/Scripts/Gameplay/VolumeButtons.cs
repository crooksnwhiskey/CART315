using UnityEngine;

public class VolumeButtons : MonoBehaviour, IInteractable
{
    
    public SpeakerController speakerController;
    public bool volumeUp;

    public void Interact()
    {
        if (volumeUp)
        {
            speakerController.IncreaseVolume();
        }
        else
        {
            speakerController.DecreaseVolume();
        }
    }
}
