using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class GetEnermyData : MonoBehaviour
{ 
    public int a, b, c, d;
    //��ȡʰȡɫ�ӵõ�������
    public List<Text> textList;
    public GameObject but;
    public GetPlayerData GetPlayer;
    public HealthManager playerHealth;
    public int playerSum;

    public int index;
    

    void Start()
    {
        but = this.gameObject;   //��������
        if (but != null)
        {
            Debug.Log(but.name);

            //�������е��������Լ������壬���ұ�����������
            for (int i = 0; i < but.GetComponentsInChildren<Text>(true).Length; i++)
            {
                textList.Add(but.GetComponentsInChildren<Text>()[i]);
            }

        }

        

        
    }

    void Update()
    {


        //��ȡ�õ�����
        //���谴�� p���˱������Ӳ��ԣ��������뱣�����ӵõ������ӿ�
       InsertData();//����ֵ����ʱ���ã�
      



    }

    public void InsertData()
    {
        if (Input.GetKeyDown(KeyCode.P) && index <= 3)
        {
            int x = UnityEngine.Random.Range(1, 7);     //���涪���ӻ�õ���
            textList[index].text = Convert.ToString(x);
            index++;
        }
    }

    public int CurrentDie()
    {
           
            if (GetPlayer.textList[0].text  == "")//����Ϊ0
            {
                if (playerHealth.i < 3)
                {
                   Debug.Log("�������0");
                      
                  }

                if (playerHealth.i >= 3)
                {
                //���Ĵ����ӵõ�abcd��
                int a = 1; int b = 2; int c = 3; int d = 4;
                playerSum = a + b + c + d - 4;
                 }
                     //�ĵ��ǲ���д���ˣ��߼�����
            return playerSum;
             }


           else if (GetPlayer.textList[1].text == "")//����Ϊ1
            {
                if (playerHealth.i < 3)
                {
                      Debug.Log("�������1");
               
                 }
                   


                else if (playerHealth.i == 3)
                {
                    //����������
                    int b = 1; int c = 2; int d = 3;
                    playerSum = b + c + d - 3 + Convert.ToInt32(GetPlayer.textList[0].text);
                }
            return playerSum;
        }



           else if (GetPlayer.textList[2].text == "")//����Ϊ2
            {
                if (playerHealth.i < 2)
                {
                    Debug.Log("�������2");
                }

                if (playerHealth.i >= 2)
                {
                    //������ɸ��
                     int c = 2; int d = 3;
                    playerSum =  c + d - 2 + Convert.ToInt32(GetPlayer.textList[0].text)+ Convert.ToInt32(GetPlayer.textList[1].text);
                }
            return playerSum;
        }


           else  if (GetPlayer.textList[3].text == "")
            {
                if(playerHealth.i < 1)
                {
                    Debug.Log("�������3");
                }
                if(playerHealth.i >= 1)
                {
                    //��һ������
                    int d = 3;
                    playerSum = d - 1+ Convert.ToInt32(GetPlayer.textList[0].text) + Convert.ToInt32(GetPlayer.textList[1].text)+ Convert.ToInt32(GetPlayer.textList[2].text);
                    
                 }
            return playerSum;
        }

        return playerSum;

    }
}
