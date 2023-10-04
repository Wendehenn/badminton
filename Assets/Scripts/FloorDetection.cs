using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorDetection : MonoBehaviour
{
    public GameObject ball;//记得拖拽新ball和tag
    public Text health;

    
    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            int i = Int32.Parse(health .text );
            if (i >= 1)
            {
                i -= 1;
                health.text = i.ToString();
            }
            else return;

        }
    }
}
