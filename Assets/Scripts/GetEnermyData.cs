using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class GetEnermyData : MonoBehaviour
{ 
    public int a, b, c, d;
    //获取拾取色子得到的数字
    public List<Text> textList;
    public GameObject but;
    public GetPlayerData GetPlayer;
    public HealthManager playerHealth;
    public int playerSum;

    public int index;
    

    void Start()
    {
        but = this.gameObject;   //查找物体
        if (but != null)
        {
            Debug.Log(but.name);

            //遍历所有的子物体以及孙物体，并且遍历包含本身
            for (int i = 0; i < but.GetComponentsInChildren<Text>(true).Length; i++)
            {
                textList.Add(but.GetComponentsInChildren<Text>()[i]);
            }

        }

        

        
    }

    void Update()
    {


        //获取得到点数
        //假设按下 p敌人保存骰子测试！！！接入保存骰子得到点数接口
       InsertData();//当有值传入时调用；
      



    }

    public void InsertData()
    {
        if (Input.GetKeyDown(KeyCode.P) && index <= 3)
        {
            int x = UnityEngine.Random.Range(1, 7);     //代替丢骰子获得点数
            textList[index].text = Convert.ToString(x);
            index++;
        }
    }

    public int CurrentDie()
    {
           
            if (GetPlayer.textList[0].text  == "")//保存为0
            {
                if (playerHealth.i < 3)
                {
                   Debug.Log("玩家死亡0");
                      
                  }

                if (playerHealth.i >= 3)
                {
                //丢四次骰子得到abcd；
                int a = 1; int b = 2; int c = 3; int d = 4;
                playerSum = a + b + c + d - 4;
                 }
                     //文档是不是写错了，逻辑不对
            return playerSum;
             }


           else if (GetPlayer.textList[1].text == "")//保存为1
            {
                if (playerHealth.i < 3)
                {
                      Debug.Log("玩家死亡1");
               
                 }
                   


                else if (playerHealth.i == 3)
                {
                    //丢三次骰子
                    int b = 1; int c = 2; int d = 3;
                    playerSum = b + c + d - 3 + Convert.ToInt32(GetPlayer.textList[0].text);
                }
            return playerSum;
        }



           else if (GetPlayer.textList[2].text == "")//保存为2
            {
                if (playerHealth.i < 2)
                {
                    Debug.Log("玩家死亡2");
                }

                if (playerHealth.i >= 2)
                {
                    //丢两次筛子
                     int c = 2; int d = 3;
                    playerSum =  c + d - 2 + Convert.ToInt32(GetPlayer.textList[0].text)+ Convert.ToInt32(GetPlayer.textList[1].text);
                }
            return playerSum;
        }


           else  if (GetPlayer.textList[3].text == "")
            {
                if(playerHealth.i < 1)
                {
                    Debug.Log("玩家死亡3");
                }
                if(playerHealth.i >= 1)
                {
                    //丢一次骰子
                    int d = 3;
                    playerSum = d - 1+ Convert.ToInt32(GetPlayer.textList[0].text) + Convert.ToInt32(GetPlayer.textList[1].text)+ Convert.ToInt32(GetPlayer.textList[2].text);
                    
                 }
            return playerSum;
        }

        return playerSum;

    }
}
