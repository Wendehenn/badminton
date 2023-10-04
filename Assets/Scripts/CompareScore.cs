using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CompareScore : MonoBehaviour
{
    public GetEnermyData GetEnermyData;
    public GetPlayerData GetPlayerData;

    public GameObject UIPanel;
    public Text playerText;
    public Text enermyText;
    public Text winnerText;

    int playerScore, enermyScore;

    public bool isSettlement=false;//�Ƿ����,����һ���л�״̬��ûд

    private void Update()
    { 
        GetScore ();
        DisplayUI();
    }

    public void Compare()
    {
        if(playerScore >enermyScore ) { Debug.Log("���ʤ��"); winnerText.text = "���ʤ��"; }
        if(playerScore < enermyScore ) { Debug.Log("����ʤ��"); winnerText.text = "����ʤ��"; }
        if (playerScore == enermyScore ) { Debug.Log("ƽ��"); winnerText.text = "ƽ��"; }
    }

    public void GetScore()
    {
        if( isSettlement==false  )
        {
            if (GetEnermyData.textList[3].text != "")
            {
            isSettlement = true;
            Debug.Log("���˱������ĸ����Ӵ���ͻȻ����");

                for(int i = 0; i < GetEnermyData.textList .Count; i++)
                {
                    enermyScore += Convert.ToInt32( GetEnermyData.textList[i].text);
                }
            
            playerScore = GetEnermyData.CurrentDie();
            Debug.Log(  "���˵���Ϊ" +enermyScore.ToString());
            Debug.Log("��ҵ���Ϊ" + playerScore.ToString());
            Compare();
            }

            if (GetPlayerData.textList[3].text != "")
            {
                isSettlement = true;
            Debug.Log("��ұ������ĸ����Ӵ���ͻȻ����");


                for (int i = 0; i < GetPlayerData .textList.Count; i++)
                {
                    playerScore += Convert.ToInt32(GetPlayerData.textList[i].text);
                }
                enermyScore = GetPlayerData.CurrentDie();
            Debug.Log("���˵���Ϊ" + enermyScore.ToString());
            Debug.Log("��ҵ���Ϊ" + playerScore.ToString());
            Compare();
            }
        
        
        }
       
    }

    public void DisplayUI()
    {
        if(isSettlement )
        {
            UIPanel .SetActive (true);
            playerText.text =  "��ҵ���Ϊ��" + Convert.ToString(playerScore);
            enermyText .text ="���˵���Ϊ��"+Convert.ToString(enermyScore);

        }

        //if(GetEnermyData .playerHealth .i==0)
        //{
        //    UIPanel.SetActive(true);
        //    winnerText.text = "����ʤ��";
        //}
        //if(GetPlayerData.enermyHealth.i == 0)
        //{
        //    UIPanel.SetActive(true);
        //    winnerText.text = "���ʤ��";
        //}


    }


   
}
