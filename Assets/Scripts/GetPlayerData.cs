using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerData : MonoBehaviour
{
    public int a, b, c, d;
    //获取拾取色子得到的数字
    public List<Text> textList;
    public GameObject but;
    public int index=0;

    public GetEnermyData  GetEnermy;
    public HealthDetection enermyHealth;
    public int enermySum;

    void Start()
    {
        but =this.gameObject ;   //查找物体
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
        
           InsertData();//当有值传入时调用；
            //获取得到点数
            //假设按下 Q玩家保存骰子测试！！！接入保存骰子得到点数接口
  
        }

        public void InsertData()
        {
            if (Input.GetKeyDown(KeyCode.Q)&&index<=3)
            {
            int x=UnityEngine.Random .Range(1,7);     //代替丢骰子获得点数
            textList[index ].text = Convert.ToString(x);
            index ++;
            }
        }



    public int  CurrentDie()//突然死亡
    {
        
            
            if (GetEnermy.textList[0] .text=="" )//保存为0
            {
                if (enermyHealth .i < 3)
                 {
                 Debug.Log("玩家死亡5");
                 }
                   

                  if (enermyHealth .i >= 3)
                 {
                   //丢四次骰子得到abcd；
                   int a = 1; int b = 2; int c = 3; int d = 4;
                   enermySum = a + b + c + d - 4;
                 }
                                      // 文档是不是写错了，逻辑不对
                     return enermySum;
             }


            else if (GetEnermy.textList[1].text  == "")//保存为1
            {
                if (enermyHealth.i < 3)
                {
                      Debug.Log("玩家死亡6");
                }
                   

                else if (enermyHealth.i >= 3)
                {
                    //丢三次骰子
                    int b = 1; int c = 1; int d = 1;
                    enermySum = b + c + d - 3 + Convert.ToInt32(GetEnermy.textList[0].text);
                   
                }
            return enermySum;
        }



            else if (GetEnermy.textList[2].text == "")//保存为2
            {
                if (enermyHealth.i < 2)
                {
                    Debug.Log("玩家死亡7");
                }

                if (enermyHealth.i >= 2)
                {
                    //丢两次筛子
                    int c = 1; int d = 1;
                    enermySum = c + d - 2 + Convert.ToInt32(GetEnermy.textList[0].text) + Convert.ToInt32(GetEnermy.textList[1].text);
                  
                }
            return enermySum;
        }


           else if (GetEnermy.textList[3].text == "")
            {
                if (enermyHealth.i < 1)
                {
                    Debug.Log("玩家死亡8");
                }
                if (enermyHealth.i >= 1)
                {
                    //丢一次骰子
                    int d = 1;
                    enermySum =  d - 1+ Convert.ToInt32(GetEnermy.textList[0].text) + Convert.ToInt32(GetEnermy.textList[1].text) + Convert.ToInt32(GetEnermy.textList[2].text);
                   
                }
            return enermySum;
        }

            return enermySum;
        
    }

}
