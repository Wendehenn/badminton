using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthManager : MonoBehaviour
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
        HealthDetection();
    }

    public void  HealthDetection()
    {
       i = Int32.Parse(healthText.text);

        if (i == 0)
        {
            Debug.Log("ÕÊº“À¿Õˆ");
            UIPanel.SetActive(true);
            winnerText.text = "µ–»À §¿˚";
        }

    }
}
