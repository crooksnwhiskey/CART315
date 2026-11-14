using UnityEngine;



public class VolumeButtons : MonoBehaviour, IInteractable
{
    public ObjectOutline outline;
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
    public void OnHover()
    {
        outline.EnableOutline();
    }
    public void OnHoverExit()
    {
        outline.DisableOutline();
    }
}
