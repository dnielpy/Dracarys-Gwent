using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Draw : MonoBehaviour
{
    public GameObject Card;
    public GameObject Hand;
    public List<GameObject> CardsInDeck;
    public static List<GameObject> CardsInHand { get; set; }    //////////// STATIC
    public static bool RoboCompletado;
    public static int cartasRestantesEnElDeck;


    // Start is called before the first frame update
    void Start()
    {
        CardsInHand = new();
    }

    public void OnClick()
    {
        bool canDraw = true;
        if (CardsInHand.Count == 10)
        {
            canDraw = false;
            RoboCompletado = false;
        }
        if (canDraw)
        {
            GameObject getRandomCard()
            {
                List<string>cardInGame = new List<string>();
                int id = UnityEngine.Random.Range(0, CardsInDeck.Count-1);
                GameObject drawCard = Instantiate(CardsInDeck[id], new Vector3(0, 0, 0), Quaternion.identity);
                drawCard.transform.SetParent(Hand.transform, false);

                return drawCard;
            }
            CardsInHand.Add(getRandomCard());
        }

    }

    public static string getName()
    {
        return CardsInHand[CardsInHand.Count - 1].name;
    }

}
