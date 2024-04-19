using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using UnityEngine.TextCore.Text;
using System;
using Newtonsoft.Json;


public class ThisCard : MonoBehaviour
{
    public class Character
    {
        public string Faccion { get; set; }
        public string ID { get; set; }
        public string Nombre { get; set; }
        public int Ataque { get; set; }
        public string Descripción { get; set; }
    }

    public List<Card> thisCard = new List<Card>();
    public string cardName;
    public int cardAtk;
    public string cardDescrption;


    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI atkText;

    public static List<Card> cardList = new List<Card>();


    void Start()
    {
        string jsonFilePath = "BaseDeDatos.json"; // Ruta al archivo JSON
        List<Character> characters = new List<Character>();

        string jsonString = File.ReadAllText(jsonFilePath);
        characters = JsonConvert.DeserializeObject<List<Character>>(jsonString);

        foreach (var carda in characters)
        {
            cardList.Add(new Card(carda.ID, carda.Nombre, carda.Ataque, carda.Descripción, carda.Faccion));
        }

        //Hagaoslo como un random
        foreach (var carta in cardList)
        {
            thisCard.Add(carta);
        }

        //Buscar el id en la lista
        foreach (var carta in thisCard)
        {
            if (carta.id == Draw.getName())
            {
                nameText.text = "" + carta.name;
                atkText.text = "" + carta.atk;
                descriptionText.text = "" + carta.descrption;
            }
        }
    }
}
