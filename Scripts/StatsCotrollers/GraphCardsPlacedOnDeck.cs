using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GraphCcardsPlacedOnDeck : MonoBehaviour
{
    public TextMeshProUGUI cartasText;

    // Update is called once per frame
    void Update()
    {
        int cartasiniciales = 34;
        int cartasrestantes = 34 - Draw.CardsInHand.Count;
        cartasText.text = StatsController.ptosSlege1.ToString(cartasrestantes.ToString());
    }
}
