using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MeeleZoneStatsController : MonoBehaviour
{
    public TextMeshProUGUI ptosText;

    // Update is called once per frame
    void Update()
    {
        ptosText.text = StatsController.ptosMeele1.ToString();
    }
}
