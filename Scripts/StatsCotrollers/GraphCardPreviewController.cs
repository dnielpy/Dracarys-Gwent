using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GraphCardPreviewController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image image; // Asigna tu imagen desde el editor de Unity arrastrándola al inspector
    private Color originalColor;
    private float loweredAlpha = 0.3f; // Define la transparencia reducida al pasar el mouse por encima

    void Start()
    {
        originalColor = image.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ChangeTransparency(loweredAlpha);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ChangeTransparency(originalColor.a);
    }

    void ChangeTransparency(float alphaValue)
    {
        Color newColor = image.color;
        newColor.a = alphaValue;
        image.color = newColor;
    }
}

