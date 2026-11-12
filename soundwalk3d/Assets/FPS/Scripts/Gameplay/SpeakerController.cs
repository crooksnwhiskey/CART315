
using UnityEngine;

public class SpeakerController : MonoBehaviour
{
    public AudioSource offSpeakerL;
    public AudioSource onSpeakerL;
    public AudioSource offSpeakerR;
    public AudioSource onSpeakerR;

    private bool isLeftOn = false;
    private bool isRightOn = false;

    public float volume = 1.0f;
    public float volumeIncrement = 0.1f;

    void Start()
    {
        offSpeakerL.volume = volume;
        onSpeakerL.volume = volume;
        offSpeakerR.volume = volume;
        onSpeakerR.volume = volume;
    }

    public void ToggleLeftSpeaker()
    {
        isLeftOn = !isLeftOn;

        if (isLeftOn)
        {
            onSpeakerL.Play();
            offSpeakerL.Stop();
        }
        else
        {
            offSpeakerL.Play();
            onSpeakerL.Stop();
        }
    }

    public void ToggleRightSpeaker()
    {
        isRightOn = !isRightOn;

        if (isRightOn)
        {
            onSpeakerR.Play();
            offSpeakerR.Stop();
        }
        else
        {
            offSpeakerR.Play();
            onSpeakerR.Stop();
        }
    }

    public void IncreaseVolume()
    {
        volume = Mathf.Clamp(volume + volumeIncrement, 0f, 2f);
        UpdateVolume();
    }

    public void DecreaseVolume()
    {
        volume = Mathf.Clamp(volume - volumeIncrement, 0f, 2f);
        UpdateVolume();
    }

    void UpdateVolume()
    {
        offSpeakerL.volume = volume;
        onSpeakerL.volume = volume;
        offSpeakerR.volume = volume;
        onSpeakerR.volume = volume;
    }
}
