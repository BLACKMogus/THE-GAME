using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class day1canteen : MonoBehaviour {

    public Text playerinput;
    static int nexttalk = 0;
    public static bool withche;

    void Start () {

        withche = false;
	}
   public static void setfalse()
    {
        withche = false;
        nexttalk = 0;

    }
    void Update () {
        Debug.Log(nexttalk);
        if (talkframe.stay == 3)//在食堂
        {
            if (withche == false)
            {
                if (talkframe.havenext == true)
                {
                    TheNext1(nexttalk);

                }

            }
            else if(withche==true)
            {
                if (talkframe.havenext == true)
                {
                    TheNext2(nexttalk);
                }
            }

        }
    }
    string[] goplace = { "  ", "时间不够了", "吃完饭还是直接去篮球场比较好", "over" };
    string[] gosport = { "", "吃完饭慢慢走过去时间应该差不多吧", "","","我想想，有什么事情忘记做了么？","over" };
    public void ButtonChoseCanteen()
    {
        if (talkframe.stay == 3)
        {
            if(withche==false)
            {
                if (playerinput.text.Contains("篮球场"))
                {
                    talkframe.go = 5;
                    talkframe.i = 1;
                    talkframe.gonext = true;
                    talkframe.output = gosport;
                }
                else
                {
                    talkframe.i = 1;
                    talkframe.output = goplace;
                }
            }   
        }
        else if(withche==true)
        {
            if (playerinput.text.Contains("篮球场"))
            {
                talkframe.go = 5;
                talkframe.gonext = true;
                talkframe.output = gosport;
            }
            else
            {
                talkframe.i = 1;
                TheNext2(6);
            }
        }  
    }

    void TheNext1(int i)
    {
        string[]zero = { "@?#?%", "刚才咖啡屋那边怎么那么吵啊", "next" }; //  string[] cooker = { "", "", "", "" };
        string[] one = { "%?^？&", "好像是有人在那边表白......", "next" };
        string[] two = { "食堂大妈", "别站那发呆啊，快把饭拿走", "挡着后面的人了", "next" };//加上撞人剧情
        string[] three = { " ", "来晚了人真多...", "还有不久就上体育课了", "干脆直接去<Color=red>篮球场</Color>吧","嗯...得先把饭吃完","","over" };

        switch (i)
        {
            case 0:
                talkframe.output =zero; stopchoose();
                break;
            case 1:
                talkframe.output = one; stopchoose();
                break;
            case 2:
                talkframe.output = two; stopchoose();
                break;
            case 3:
                
                talkframe.output =three; stopchoose();
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

    void TheNext2(int i)
    {
        string[] zero = { "名字", "你刚才没事吧", "next" }; //  string[] cooker = { "", "", "", "" };
        string[] one = { "车中桐", "唉，心情不好，不想说话", "next" };
        string[] two = { "车", "算了，她能分到一班就好了", "", "next" };//加上撞人剧情
        string[] three = { " 名字", "......", "", "next" };
        string[]  four = { " 名字", "......", "", "next" };
        string[] five = { "车中桐", "吃完了，走吧", "直接去篮球场吧", "over" };

        string[] response = { "车中桐", "走啊", "还等什么","下午是体育课吧", "over" };

        switch (i)
        {
            case 0: talkframe.output = zero; stopchoose(); break;
            case 1:talkframe.output = one; stopchoose(); break;
            case 2: talkframe.output = two; stopchoose(); break;
            case 3: talkframe.output = three; stopchoose(); break;
            case 4: talkframe.output = four; stopchoose(); break;
            case 5: talkframe.output = five; stopchoose(); break;
            case 6: talkframe.output =response; stopchoose(); break;
            default: break;
        }
    }







}
