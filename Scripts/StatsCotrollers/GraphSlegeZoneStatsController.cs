using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GraphSlegeZoneStatsController : MonoBehaviour
{
    public TextMeshProUGUI ptosText;

    // Update is called once per frame
    void Update()
    {
        ptosText.text = StatsController.ptosSlege1.ToString();
    }
}
