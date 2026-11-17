using UnityEngine;

public class AudioText : MonoBehaviour
{
    public SpeakerController speakerController;
    public SpeakerController leftSpeakerController;

    private TextMesh displayText;

    void Start()
    {
        displayText = GetComponent<TextMesh>();
    }

    void Update()
    {
        displayText.text =
            "SPEED: " + leftSpeakerController.audioSpeed.ToString("F2") + "x\n" +
            "VOLUME: " + (speakerController.volume * 100).ToString("F0") + "%";
    }
}
