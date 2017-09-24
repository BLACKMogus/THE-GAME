using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class day1gate : MonoBehaviour
{

    string playernamee;
    private static day1gate times;
    int come;
    
    void Awake()
    {
        times = this;
    }
    void Start()
    {
       
    }


    void Update()
    {
        playernamee = playername.getname();
        if (talkframe.stay == 1)//在校门口
        {
            if (talkframe.havenext == true)
            {
                talkframe.output = choose(playername.gettimes());
                talkframe.havenext = false;
            }
        }
    }
    string[] choose(int n)
    {
        string[] test;
        if (n == 0)
        {
            morning[1]=string.Concat(morning[1], playernamee);  
            test = morning;
            return test;
        }
        else if (n == 1)
        {
            second[0] = string.Concat(second[0], playernamee);
            test = second;
            n = 0;
            return test;
        }
        else if (n == 2)
        {
            third[0] = string.Concat(third[0], playernamee);
            third[3] = string.Concat(third[3], playernamee);
            test = third;
            n = 0;
            return test;
        }
        else if (n == 3)
        {
           forth[3] = string.Concat(forth[3], playernamee);
            test = forth;
            n = 0;
            return test;
        }
        else if (n == 4)
        {
            test = fifth;
            n = 0;
            return test;
        }
        else
            return null; 
    }
    string[] second = { "", "啊~~·困死了", "诶，桐子，一大早又遇见你了", "next" };
    string[] third = { "", "啊~~怎么还是跟昨天一样困啊", "桐子怎么又是你啊...",  "next" };
    string[] forth = { "", "又是这样，和昨天一模一样！", "难道...难道我一直在同一天当中么", "桐子的下一句是————早啊...", "next" };
    string[] fifth = { "", "看来真的是这样，怪不得我每次上课到一半就会突然睡着", "嗯，绝对不是因为我通宵玩手机", "这样的话我岂不是...","永远无法迎来周末了！！！","不要啊QAQ", "next" };
    string[] non = { "", "第五天之后的话还没做出来", "玩到这里的话再提醒我", "next" };//正式要加东西！！！




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
            if (playerinput.text.Contains("早") || playerinput.text.Contains("哦") || playerinput.text.Contains("好") || playerinput.text.Contains("嗯"))
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
            talkframe.gonext = true;
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