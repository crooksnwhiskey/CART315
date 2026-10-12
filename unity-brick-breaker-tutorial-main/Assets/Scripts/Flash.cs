using UnityEngine;
using System.Collections;
public class Flash : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    public void flash(Color flashColor, float duration)
    {
        StartCoroutine(FlashCoroutine(flashColor, duration));
    }

    private IEnumerator FlashCoroutine(Color flashColor, float duration)
    {
        spriteRenderer.color = flashColor;
        yield return new WaitForSeconds(duration);
        spriteRenderer.color = originalColor;
    }
}
