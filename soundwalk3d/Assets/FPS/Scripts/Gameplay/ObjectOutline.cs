using UnityEngine;

public class ObjectOutline : MonoBehaviour
{
    public Material outlineMaterial;
    private Material originalMaterial;
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponentInChildren<Renderer>();
        originalMaterial = objectRenderer.material;
    }

    public void EnableOutline()
    {
        objectRenderer.material = outlineMaterial;
    }

    public void DisableOutline()
    {
        objectRenderer.material = originalMaterial;
    }
}
