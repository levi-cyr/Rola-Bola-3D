using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class Contador : MonoBehaviour
{
    public TMP_Text timeLevel_txt;
    public static float timeLevel = 35f;
    public static bool stopTime;
    void Start()
    {
        stopTime = false;
    }

    void Update()
    {
        if (stopTime == false)
        {
            timeLevel = timeLevel - Time.deltaTime;
            timeLevel_txt.text = "Tempo: " + timeLevel.ToString("F0");
        }

    }
}
