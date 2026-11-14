using UnityEngine;

public class SpeedButtons : MonoBehaviour, IInteractable
{

    public SpeakerController speakerController;
    public bool speedUp;
    public bool levelSpeed;

    public void Interact()
    {
        if (speedUp)
        {
            speakerController.IncreaseAudioSpeed();
            }
        else if (levelSpeed)
        {
            speakerController.LevelAudioSpeed();
        }
        else
        {
            speakerController.DecreaseAudioSpeed();
        }
    }
}