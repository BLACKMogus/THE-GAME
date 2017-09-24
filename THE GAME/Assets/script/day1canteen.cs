using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class day1canteen : MonoBehaviour {

    public Text playerinput;
    bool first;
    int nexttalk = 0;
    bool soccor;

    void Start () {
        first = false;
	}
   
    void Update () {

        if (talkframe.stay == 3)//在食堂
        {
              ChoseNextTalk();
          

        }
    }
    string[] goplace = { "  ", "时间不够了", "还是直接去篮球场比较好", "over" };
  
    public void ButtonChoseCanteen()
    {
        if (talkframe.stay == 3)
        {
            if (playerinput.text.Contains("篮球场"))
            {
                talkframe.go = 5;
                talkframe.i = 0;
                talkframe.gonext = true;
            }
            else talkframe.output = goplace;
        }
    }

    void TheNext(int i)
    {
        string[] people1 = { "@?#?%", "刚才咖啡屋那边怎么那么吵啊", "next" }; //  string[] cooker = { "", "", "", "" };
        string[] people2 = { "%?^？&", "好像是有人在那边表白......", "next" };
        string[] cooker = { "食堂大妈", "别站那发呆啊，快把饭拿走", "挡着后面的人了", "next" };
        string[] heart = { " ", "来晚了人真多...", "还有不久就上体育课了", "干脆直接去<Color=red>篮球场</Color>吧", "over" };

        switch (i)
        {
            case 0:
                talkframe.output = people1; stopchoose();
                break;
            case 1:
                talkframe.output = people2; stopchoose();
                break;
            case 2:
                talkframe.output = cooker; stopchoose();
                break;
            case 3:
                heart[0] = string.Concat(playername.getname(), heart[0]);
                talkframe.output = heart; stopchoose();
                break;
            default: break;
        }
    }
    void stopchoose()
    {
        talkframe.i = 1;
        nexttalk++;
        talkframe.havenext = false;
    }

    void ChoseNextTalk()
    {
        TheNext(nexttalk);
        if(talkframe.havenext==true)
        {
            TheNext(nexttalk);
        }
    }








}
