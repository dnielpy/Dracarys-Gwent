using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ThisCard;

public class StatsController : MonoBehaviour
{
    public GameObject Hand;
    public GameObject Card;
    public GameObject MeleZone;
    public GameObject SlegeZone;
    public GameObject RangedZone;

    public static int ptosTotales;
    public static int ptosMeele1;
    public static int ptosRanged1;
    public static int ptosSlege1;



    // Update is called once per frame
    void Update()
    {
        ptosMeele1 = 0;
        ptosRanged1 = 0;
        ptosSlege1 = 0;
        ptosTotales = 0;
        //Este codigo es para updatear el total de ptos
        //Sacar puntos de meeleZone

        /*El error lo da pq los campos meele etc, se crean cuando se llama a Movement por primera vez, y en este momento del juego aun no estan
        Pero no tiene importancia*/
        if (Movement.MeleeZone.Count != 0)
        {            
            foreach (var cartaenmano in Movement.MeleeZone)
            {
                int atk = 0;
                //Coger el id de la carta y buscar su faccion en la bd
                foreach (var carta in cardList)
                {
                 if (carta.id == cartaenmano.name)
                    {
                        atk += carta.atk;
                        break;
                    }
                }
                ptosMeele1 += atk;
                ptosTotales += atk;
            }
        }

        //Sacar puntos de SlegeZone
        if (Movement.SlegeZone.Count != 0)
        {            
            foreach (var cartaenmano in Movement.SlegeZone)
            {
                int atk = 0;
                //Coger el id de la carta y buscar su faccion en la bd
                foreach (var carta in cardList)
                {
                 if (carta.id == cartaenmano.name)
                    {
                        atk += carta.atk;
                        break;
                    }
                }
                ptosSlege1 += atk;
                ptosTotales += atk;
            }
        }

        //Sacar puntos de RangeZone
        if (Movement.RangedZone.Count != 0)
        {            
            foreach (var cartaenmano in Movement.RangedZone)
            {
                int atk = 0;
                //Coger el id de la carta y buscar su faccion en la bd
                foreach (var carta in cardList)
                {
                 if (carta.id == cartaenmano.name)
                    {
                        atk += carta.atk;
                        break;
                    }
                }
                ptosRanged1 += atk;
                ptosTotales += atk;
            }
        }
    }
}
