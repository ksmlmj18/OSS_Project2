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
        //대사 생성 
        talkData.Add(1000, new string[] { "엥? 이런곳에 사람이?!?!" });
        talkData.Add(100, new string[] { "문이 열리는 소리가 들렸다." });

    }

    public string GetTalk(int id, int talkIndex) //Object의 id , string배열의 index
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex]; //해당 아이디의 해당
    }


}
