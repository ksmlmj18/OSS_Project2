using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManaer : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    // Start is called before the first frame update
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        //��� ���� 
        talkData.Add(1000, new string[] { "��? �̷����� �����?!?!" });
        talkData.Add(100, new string[] { "���� ������ �Ҹ��� ��ȴ�." });

    }

    public string GetTalk(int id, int talkIndex) //Object�� id , string�迭�� index
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex]; //�ش� ���̵��� �ش�
    }


}
