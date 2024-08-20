using System.Collections;
using UnityEngine;

public class FadeEffect : MonoBehaviour
{
    private Renderer objectRenderer;
    private Material objectMaterial;
    private Color originalColor;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        objectMaterial = objectRenderer.material;
        originalColor = objectMaterial.color;
    }

    public void FadeOut(float duration)
    {
        StartCoroutine(FadeTo(0.0f, duration));
    }

    public void FadeIn(float duration)
    {
        StartCoroutine(FadeTo(originalColor.a, duration));
    }

    private IEnumerator FadeTo(float targetAlpha, float duration)
    {
        float startAlpha = objectMaterial.color.a;
        float elapsedTime = 0.0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float newAlpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / duration);
            Color newColor = new Color(originalColor.r, originalColor.g, originalColor.b, newAlpha);
            objectMaterial.color = newColor;
            yield return null;
        }
    }
}

