using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using static ThisCard;

public class TextMeshProCardInfo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private string originalText;
    public Vector2 zoomedPosition; // Coordenadas donde se mostrará el texto ampliado
    private TextMeshProUGUI zoomedText;

    void Start()
    {
        CreateZoomedText();
        HideZoomedText();
    }

    void CreateZoomedText()
    {
        foreach (var carta in cardList)
        {
            if (carta.id == gameObject.name)
            {
                originalText = carta.descrption;
                break;
            }
        }
        Debug.Log(originalText);
       
         // Crear una instancia del TextMeshProUGUI ampliado en las coordenadas deseadas
    GameObject zoomedTextGO = new GameObject("ZoomedText");
    zoomedText = zoomedTextGO.AddComponent<TextMeshProUGUI>();
    zoomedText.rectTransform.SetParent(transform.parent); // Ajustar el padre al mismo padre que el texto original
    zoomedText.rectTransform.localScale = new Vector3(0.8f, 0.8f, 0.8f); // Reducir la escala del texto
    zoomedText.rectTransform.localPosition = zoomedPosition; // Establecer las coordenadas especificadas
    zoomedText.text = originalText;
    zoomedText.alignment = TextAlignmentOptions.TopLeft; // Alinear el texto de izquierda a derecha y de arriba a abajo
    //zoomedText.alignment = TextAlignmentOptions.Center; // Centrar el texto
    zoomedText.fontSize = 16; // Tamaño de fuente predeterminado
    //zoomedText.enableAutoSizing = true; // Habilitar ajuste automático de tamaño de fuente
    zoomedText.gameObject.SetActive(false);
    }

    void ShowZoomedText()
    {
        // Mostrar el TextMeshProUGUI ampliado en las coordenadas especificadas
        zoomedText.gameObject.SetActive(true);
    }

    void HideZoomedText()
    {
        // Ocultar el TextMeshProUGUI ampliado
        zoomedText.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Mostrar el TextMeshProUGUI ampliado cuando el mouse entra en el objeto
        ShowZoomedText();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Ocultar el TextMeshProUGUI ampliado cuando el mouse sale del objeto
        HideZoomedText();
    }
}