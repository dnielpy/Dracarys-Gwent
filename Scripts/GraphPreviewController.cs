using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GraphPreviewController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI previewText; // Referencia al texto a mostrar
    public string textoAMostrar = "Texto de ejemplo"; // Texto por defecto a mostrar

    void Start()
    {
        // Mostrar el texto por defecto al inicio
        SetPreviewText(textoAMostrar);
        HidePreviewText(); // Ocultar el texto inicialmente
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Mostrar el texto cuando el mouse entra en el área de la vista previa
        ShowPreviewText();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Ocultar el texto cuando el mouse sale del área de la vista previa
        HidePreviewText();
    }

    void SetPreviewText(string texto)
    {
        // Establecer el texto a mostrar
        previewText.text = texto;
    }

    void ShowPreviewText()
    {
        // Mostrar el texto
        previewText.gameObject.SetActive(true);
    }

    void HidePreviewText()
    {
        // Ocultar el texto
        previewText.gameObject.SetActive(false);
    }
}
