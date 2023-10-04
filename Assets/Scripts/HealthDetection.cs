using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HealthDetection : MonoBehaviour
{
    public Text healthText;
    public Text winnerText;
    public GameObject UIPanel;
    public int i { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthDetectio();
    }

    public void HealthDetectio()
    {
        int i = Int32.Parse(healthText.text);

        if (i == 0)
        {
            Debug.Log("µ–»ÀÀ¿Õˆ");
            UIPanel.SetActive(true);
             winnerText.text = "ÕÊº“ §¿˚";
        }

    }
}
