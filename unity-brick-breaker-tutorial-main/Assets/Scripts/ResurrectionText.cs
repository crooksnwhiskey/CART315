using UnityEngine;
using TMPro;
using System.Collections;

public class PopupText : MonoBehaviour
{
    private TextMeshProUGUI label;

    private void Awake()
    {
        label = GetComponent<TextMeshProUGUI>();
        label.alpha = 0f; 
    }

    public void Show(string message, float duration)
    {
        StopAllCoroutines();
        StartCoroutine(ShowRoutine(message, duration));
    }

    private IEnumerator ShowRoutine(string message, float duration)
    {
        label.text = message;
        label.alpha = 1f;

        yield return new WaitForSeconds(duration);

       
        float t = 0f;
        while (t < 0.5f) {
            t += Time.deltaTime;
            label.alpha = Mathf.Lerp(1f, 0f, t / 0.5f);
            yield return null;
        }
        label.alpha = 0f;
    }
}