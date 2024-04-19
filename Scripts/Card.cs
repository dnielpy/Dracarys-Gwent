using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string id;
    public string name;
    public string faccion;
    public int atk;
    public string descrption;
    internal int Ataque;

    public Card(){

    }

    public Card(string ID, string cardName, int cardAtk, string cardDescrption, string Faccion){
        faccion = Faccion;
        id = ID;
        name = cardName;
        atk = cardAtk;
        descrption = cardDescrption;
    }

    public string Nombre { get; internal set; }
}
