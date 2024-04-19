using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ptosGraphController : MonoBehaviour
{
    public TextMeshProUGUI ptosText;

    // Update is called once per frame
    void Update()
    {
        ptosText.text = StatsController.ptosTotales.ToString();
    }
}
