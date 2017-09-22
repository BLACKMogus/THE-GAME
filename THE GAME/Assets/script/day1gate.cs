using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class day1gate : MonoBehaviour
{

    
    void Awake()
    {
        talkframe.output = morning;
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    string[] morning = { "车中桐","早啊...", "一大早的真是困死我了","啊~啊~~~", "over" };//开头
    string[] noon = { "车中桐", "你没睡醒吧...现在是早上啊", "over" };//午。晚
    string[] breakfast = { "车中桐", "还没吃呢...赶着上课啊", "over" };//早餐
    string[] classroom = { "车中桐", "快走，要打铃了", "over" };
    string[] nulll;
    
    public Text playerinput;

    public void ButtonChooseAnswer()
    {
        talkframe.i = 1;
        if (talkframe.stay == 1)//在校门口
        {
            talkframe.output = change();
        }
    }
    string[] change()
    {
        if (playerinput.text.Contains("午") || playerinput.text.Contains("晚"))
        {
            return noon;

        }
        if (playerinput.text.Contains("早餐"))
        {
            return breakfast;
        }
        if (playerinput.text.Contains("课室") || playerinput.text.Contains("教室"))
        {
            talkframe.go = 1;
            return classroom;

        }
        else return randommanswer();   
    }
    string[] A = { "车中桐", "你说啥，风太大我听不见", "over" };
    string[] B = { "车中桐", "再不走就要迟到了", "over" };
    string[] C = { "车中桐", "你真的不是在逗我么...", "over" };
    string[] D = { "车中桐", "感觉你在说废话啊 = =", "over" };

    string[] randommanswer()
    {
      
        int o = Random.Range(0, 4);
        if (o == 0)
        {
            nulll =A; 
        }
     
        if (o == 1)
        {
            nulll = B;
        }
        if (o == 2)
        {
            nulll = C;
        }
        if (o == 3)
        {
            nulll = D;
        }
        return nulll;
    }
}