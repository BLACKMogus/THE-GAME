using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class day1gate : MonoBehaviour
{

    string playernamee;
    bool firstcome;
    void Start()
    {
        firstcome = true;
    }

    void Update()
    {

          playernamee = playername.getname();
        if (talkframe.stay == 1)//在校门口
        {
            if (firstcome==true)
            {
                morning[1]=string.Concat(morning[1], playernamee);  
                talkframe.output = morning;
                
                firstcome = false;
            }
          
        }
    }

    string[] morning = { "车中桐","早啊...", "over" };//开头        "昨晚睡得好晚，今天还要六点多起床", "困死我了啊~啊~~~",

    string[] noon = { "车中桐", "你没睡醒吧...现在是早上啊", "over" };//午。晚
    string[] breakfast = { "车中桐", "还没吃呢...赶着上课啊", "over" };//早餐
    string[] che= { "车中桐", "我？我怎么了", "over" };

    string[] shuai = { "车中桐", "啊~没想到我隐藏的这么深还是被你发现了", "over" };
    string[] sha  = { "车中桐", "你才傻呢", "over" };

    string[] nulll;
    string[] classroom = { "车中桐", "快走，要打铃了"," ","over" };//按钮显现
    string[] answer = { "车中桐", "我看看啊，现在是......", "哇还有不到三分钟了", "快快快去<Color=red>课室</Color>，今天早读是那个巨凶的数学老师","我才不想被点名", "over" };//正确答案
    
    public Text playerinput;

    public void ButtonChooseGateAnswer()
    {
       
        if (talkframe.stay == 1)//在校门口
        {
            talkframe.i = 1;
            talkframe.output = changeanswer();//选用一个回答
        }
      
    }


    string[] changeanswer()
    {
            if (playerinput.text.Contains("午") || playerinput.text.Contains("晚"))
            {
                return noon;

            }
            if (playerinput.text.Contains("早餐"))
            {
                return breakfast;
            }
            if (playerinput.text.Contains("早") || playerinput.text.Contains("哦") || playerinput.text.Contains("好"))
            {

                return answer;
            }
            if (playerinput.text.Contains("车中桐"))
            {
                return che;   
            }
            if (playerinput.text.Contains("课") || playerinput.text.Contains("教"))
            {
                talkframe.go = 2;
                return classroom;
            } 
            if (playerinput.text.Contains("帅"))
            {
                return shuai;
            }
            if (playerinput.text.Contains("傻"))
            {
                return sha;
            }
        else return randommanswer();   
    }
    string[] A = { "车中桐", "你说啥，风太大我听不见", "over" };
    string[] B = { "车中桐", "再不走就要迟到了", "over" };
    string[] C = { "车中桐", "你真的不是在逗我么...", "over" };
    string[] D = { "车中桐", "你说的真的是中文么...", "over" };
    string[] E = { "车中桐", "这只是第一关哪来那么多关键词给你试      ╭(╯^╰)╮", "over" };//随机回答

    string[] randommanswer()
    {

        int o = Random.Range(0, 5);
       
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
        if (o == 4)
        {
            nulll = E;
        }
        return nulll;
    }
}