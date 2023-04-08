using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int talkIndex;
    public TalkManager talkmanager;
    public GameObject talkPanel;
    public Text TalkText;
    public GameObject scanObject;
    public bool isAction;
    public Image portaraitImg;
    public void Action(GameObject scanObj)
    {
        
       
           
            scanObject = scanObj;
            ObjectData objData = scanObject.GetComponent<ObjectData>();
            Talk(objData.id, objData.isNpc);
            talkPanel.SetActive(isAction);


        }


    void Talk(int id, bool isNpc)
    {


       string talkData= talkmanager.GetTalk(id, talkIndex);
       
        if(talkData == null)
        {
            isAction = false;
            talkIndex = 0;

            return;
        }


        if (isNpc)
        {
            TalkText.text = talkData.Split(':')[0] ;
            portaraitImg.sprite = talkmanager.GetPortrait(id,int.Parse(talkData.Split(':')[1]));
            portaraitImg.color = new Color(1, 1, 1, 1);
        }
        else
        {
            TalkText.text = talkData;
            portaraitImg.color = new Color(1, 1, 1, 0);
        }

        isAction = true;
        talkIndex++;
    
    
    
    }
}
