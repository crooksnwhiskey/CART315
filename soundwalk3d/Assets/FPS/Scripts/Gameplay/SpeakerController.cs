using UnityEngine;

public class SpeakerController : MonoBehaviour
{

public AudioSource offSpeakerL;
public AudioSource onSpeakerL;
public AudioSource offSpeakerR;
public AudioSource onSpeakerR;
private bool isOn = false;
public float volume = 1.0f;
public float volumeIncrement = 0.1f;

    void Start()
    {
        offSpeakerL.volume = volume;
        onSpeakerL.volume = volume;
        offSpeakerR.volume = volume;
        onSpeakerR.volume = volume;
    }
public void ToggleSpeaker()
{
    isOn = !isOn;
    if (isOn)
    {
        onSpeakerL.Play();
        offSpeakerL.Stop();
        onSpeakerR.Play();
        offSpeakerR.Stop();
    }
    else
    {
        offSpeakerL.Play();
        onSpeakerL.Stop();
        offSpeakerR.Play();
        onSpeakerR.Stop();
      }
    }
    public void IncreaseVolume()
    {
        volume = Mathf.Clamp(volume + volumeIncrement, 0f, 2f);
        offSpeakerL.volume = volume;
        onSpeakerL.volume = volume;
        offSpeakerR.volume = volume;
        onSpeakerR.volume = volume;
    }
    public void DecreaseVolume()
    {
        volume = Mathf.Clamp(volume - volumeIncrement, 0f, 2f);
        offSpeakerL.volume = volume;
        onSpeakerL.volume = volume;
        offSpeakerR.volume = volume;
        onSpeakerR.volume = volume;
    }
}