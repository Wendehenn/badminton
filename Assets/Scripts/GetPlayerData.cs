using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerData : MonoBehaviour
{
    public int a, b, c, d;
    //��ȡʰȡɫ�ӵõ�������
    public List<Text> textList;
    public GameObject but;
    public int index=0;

    public GetEnermyData  GetEnermy;
    public HealthDetection enermyHealth;
    public int enermySum;

    void Start()
    {
        but =this.gameObject ;   //��������
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
        
           InsertData();//����ֵ����ʱ���ã�
            //��ȡ�õ�����
            //���谴�� Q��ұ������Ӳ��ԣ��������뱣�����ӵõ������ӿ�
  
        }

        public void InsertData()
        {
            if (Input.GetKeyDown(KeyCode.Q)&&index<=3)
            {
            int x=UnityEngine.Random .Range(1,7);     //���涪���ӻ�õ���
            textList[index ].text = Convert.ToString(x);
            index ++;
            }
        }



    public int  CurrentDie()//ͻȻ����
    {
        
            
            if (GetEnermy.textList[0] .text=="" )//����Ϊ0
            {
                if (enermyHealth .i < 3)
                 {
                 Debug.Log("�������5");
                 }
                   

                  if (enermyHealth .i >= 3)
                 {
                   //���Ĵ����ӵõ�abcd��
                   int a = 1; int b = 2; int c = 3; int d = 4;
                   enermySum = a + b + c + d - 4;
                 }
                                      // �ĵ��ǲ���д���ˣ��߼�����
                     return enermySum;
             }


            else if (GetEnermy.textList[1].text  == "")//����Ϊ1
            {
                if (enermyHealth.i < 3)
                {
                      Debug.Log("�������6");
                }
                   

                else if (enermyHealth.i >= 3)
                {
                    //����������
                    int b = 1; int c = 1; int d = 1;
                    enermySum = b + c + d - 3 + Convert.ToInt32(GetEnermy.textList[0].text);
                   
                }
            return enermySum;
        }



            else if (GetEnermy.textList[2].text == "")//����Ϊ2
            {
                if (enermyHealth.i < 2)
                {
                    Debug.Log("�������7");
                }

                if (enermyHealth.i >= 2)
                {
                    //������ɸ��
                    int c = 1; int d = 1;
                    enermySum = c + d - 2 + Convert.ToInt32(GetEnermy.textList[0].text) + Convert.ToInt32(GetEnermy.textList[1].text);
                  
                }
            return enermySum;
        }


           else if (GetEnermy.textList[3].text == "")
            {
                if (enermyHealth.i < 1)
                {
                    Debug.Log("�������8");
                }
                if (enermyHealth.i >= 1)
                {
                    //��һ������
                    int d = 1;
                    enermySum =  d - 1+ Convert.ToInt32(GetEnermy.textList[0].text) + Convert.ToInt32(GetEnermy.textList[1].text) + Convert.ToInt32(GetEnermy.textList[2].text);
                   
                }
            return enermySum;
        }

            return enermySum;
        
    }

}
