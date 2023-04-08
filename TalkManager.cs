using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{


    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portaraitData;

    public Sprite[] portaraitarr;
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portaraitData= new Dictionary<int, Sprite>();
        GenerateData();
    }


    void GenerateData()
    {
        talkData.Add(1000, new string[] { "안녕?:0" , "이곳에 처음왔구나?:1" });
        talkData.Add(100, new string[] { "난 그냥 상자야" });
        talkData.Add(200, new string[] { "난 더러운 책상이야" });
        talkData.Add(2000, new string[] { "넌:0", "내타입이 아냐:1","썩 사라져:2" });



        portaraitData.Add(2000 + 0, portaraitarr[0]);
        portaraitData.Add(2000 + 1, portaraitarr[1]);
        portaraitData.Add(2000 + 2, portaraitarr[2]);
        portaraitData.Add(2000 + 3, portaraitarr[3]);

        portaraitData.Add(1000 + 0, portaraitarr[5]);
        portaraitData.Add(1000 + 1, portaraitarr[6]);
        portaraitData.Add(1000 + 2, portaraitarr[7]);
        portaraitData.Add(1000 + 3, portaraitarr[8]);
    } 
    // Update is called once per frame
    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];


     
    }



    public Sprite GetPortrait(int id, int portraitindex)
    {
        return portaraitData[id + portraitindex];
    }



}
