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

    public bool isSettlement=false;//是否结算,到下一局切换状态还没写

    private void Update()
    { 
        GetScore ();
        DisplayUI();
    }

    public void Compare()
    {
        if(playerScore >enermyScore ) { Debug.Log("玩家胜利"); winnerText.text = "玩家胜利"; }
        if(playerScore < enermyScore ) { Debug.Log("敌人胜利"); winnerText.text = "敌人胜利"; }
        if (playerScore == enermyScore ) { Debug.Log("平局"); winnerText.text = "平局"; }
    }

    public void GetScore()
    {
        if( isSettlement==false  )
        {
            if (GetEnermyData.textList[3].text != "")
            {
            isSettlement = true;
            Debug.Log("敌人保存了四个骰子触发突然死亡");

                for(int i = 0; i < GetEnermyData.textList .Count; i++)
                {
                    enermyScore += Convert.ToInt32( GetEnermyData.textList[i].text);
                }
            
            playerScore = GetEnermyData.CurrentDie();
            Debug.Log(  "敌人点数为" +enermyScore.ToString());
            Debug.Log("玩家点数为" + playerScore.ToString());
            Compare();
            }

            if (GetPlayerData.textList[3].text != "")
            {
                isSettlement = true;
            Debug.Log("玩家保存了四个骰子触发突然死亡");


                for (int i = 0; i < GetPlayerData .textList.Count; i++)
                {
                    playerScore += Convert.ToInt32(GetPlayerData.textList[i].text);
                }
                enermyScore = GetPlayerData.CurrentDie();
            Debug.Log("敌人点数为" + enermyScore.ToString());
            Debug.Log("玩家点数为" + playerScore.ToString());
            Compare();
            }
        
        
        }
       
    }

    public void DisplayUI()
    {
        if(isSettlement )
        {
            UIPanel .SetActive (true);
            playerText.text =  "玩家点数为：" + Convert.ToString(playerScore);
            enermyText .text ="敌人点数为："+Convert.ToString(enermyScore);

        }

        //if(GetEnermyData .playerHealth .i==0)
        //{
        //    UIPanel.SetActive(true);
        //    winnerText.text = "敌人胜利";
        //}
        //if(GetPlayerData.enermyHealth.i == 0)
        //{
        //    UIPanel.SetActive(true);
        //    winnerText.text = "玩家胜利";
        //}


    }


   
}
