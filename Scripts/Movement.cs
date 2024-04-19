using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using static ThisCard;
using System.IO;

public class Movement : MonoBehaviour
{
    public GameObject Zona;
    public GameObject Card;
    public GameObject MeeleZone;
    public List<GameObject> CardsInHand;

    public static List<GameObject> MeleeZone { get; set; }    
    public static List<GameObject> SlegeZone { get; set; }   
    public static List<GameObject> RangedZone { get; set; } 
    public static List<GameObject> CampZone { get; set; } 

    
    public void Start(){
        MeleeZone = new();
        SlegeZone = new();
        RangedZone = new();
        CampZone = new();
    }

    public void OnClick(){
        string faccion = "";

        //Coger el id de la carta y buscar su faccion en la bd
        foreach (var carta in cardList)
        {
            if (carta.id == Card.name)
            {
                faccion += carta.faccion;

                if (faccion == "MeleeZone")
                    {
                        MeleeZone.Add(Card);
                }
                if (faccion == "SlegeZone")
                    {
                        SlegeZone.Add(Card);
                }
                if (faccion == "RangedZone")
                    {
                        RangedZone.Add(Card);
                }
                if (faccion == "CampZone")
                    {
                        CampZone.Add(Card);
                }
                break;
            }
        }
        
        Zona = GameObject.Find(faccion);
        Card.transform.SetParent(Zona.transform, false);
    }
}

