using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class day1class : MonoBehaviour
{
    public Text playerinput;
    bool first;
    int nexttalk;
    string pname;
    bool blamee;
    bool question;
    bool answerquestion;
    void Start()
    {
        answerquestion = false;
        question = false;
        blamee =  false;
        first = true;
        nexttalk = 0;
    }

    void Update()
    {
        
        pname = playername.getname();
        if (talkframe.stay == 2)//在校门口
        {
            if (first == true)
            {
                sleep[0] = string.Concat(sleep[0], pname);
                talkframe.output = sleep;
                first = false;
            }
            if (talkframe.havenext == true)
            {
               
                    ChoseNextTalk();
            }

        }
       
    }

    void ChoseNextTalk()
    {
        if (nexttalk == 0)
        {
            teacherask[1] = string.Concat(pname, teacherask[1]);
            teacherask[2] = string.Concat(pname, teacherask[2]);
            talkframe.output = teacherask;
            answerquestion = true;
            stopchoose();
        }
       else if (nexttalk == 1)
        {
            talkframe.output = cheanswer;//车中桐回答了
            stopchoose();
        }
        else if (nexttalk == 2)
        {
            talkframe.output = teacherboost;//老师表扬车中桐，留下玩家    正式要加入名字
            stopchoose();
        }
        else if(nexttalk==3)
        {
            talkframe.output = continueclass;
            stopchoose();
        }
        else if (nexttalk == 4)

        {
            
            talkframe.output = bell;
            stopchoose();
        }
        else if (nexttalk == 5)

        {talkframe.output =blame;
            stopchoose(); }
        else if (nexttalk == 6)

        {talkframe.output = wait;
            stopchoose(); }
        else if (nexttalk == 7)

        {talkframe.output =blameconti;
            blamee = true;
            stopchoose(); }
        else if(nexttalk==8)
        { talkframe.output =anyquestion;
            question = true;
            blamee = true;
            stopchoose(); }

    }
    void stopchoose()
    {
        talkframe.i = 1;
        nexttalk++;
        talkframe.havenext = false;
    }
   /*开场话*/ string[] sleep = { "", "zzzz", "next" };// "zzzzzzzz", "zzzzzzzzzzz",             { "车中桐", "", "", "", "", "next" };
    /*0*/ string[] teacherask = { "老师", "  ", "  !", "起来回答一下这个问题", "over" };//开头 
    /*return*/ string[] wronganswer = { "老师", "搞事？搞事？", "不回答还不好好听课", "下课后给我留下来","车中桐，你来回答一下", "next" };// 

    //回答错误的线
    /*1*/ string[] cheanswer = { "车中桐", "<Color=red>新加坡</Color>","next" };
    /*2*/  string[] teacherboost = { "老师", "嗯，很好,坐下吧", "我在这里顺便就说一下啊", "这次分班考试车中桐的总分是<Color=red>年级第一</Color>",
                        "这和他一直保持勤奋好学是脱不开干系的", " “  名字  ”  ，你多学学人家，知道吗？", "另外，你待会下课留一下","next" };//
    //回答正确的线
    string[] rightanswer = { "老师", "嗯，还不错，坐下吧", "next" };
    /*3*/ string[] continueclass = {"老师", "我们继续上课", "这道题嘛，首先A肯定是错的", "B明显不对", "C一看就不符合题意", "所以选D", "好，下一题......", "next" };// 
    /*4*/ string[] bell = { "铃声", "3125,5132", "next" };

    /*5*/  string[] blame = { "老师","欢乐的时光总是短暂的", "我们下课", "“名字”", "你过来", "next" };
    /*6*/ string[] wait = { "车中桐", "我在外面等你", "next" };
    /*7*/ string[] blameconti = {"老师","车中桐和你是同桌", "多学学他的优点", "虽然上课睡觉是小事", "但是长期下去也会影响学习", "下次再看到你睡觉，就让你去后面罚站","知道了吗？","over" };
    //回答不知道
    /*return*/ string[] sayagain = { "老师", "看来你还是没开窍，好，那我再说一遍", "车中桐和你是同桌", "多学学他的优点", "虽然上课睡觉是小事", "但是长期下去也会影响学习",
                      "下次再看到你睡觉，就让你去后面罚站", "知道了吗？", "over" };
    //回答知道
    /*return*/  string[] anyquestion = { "老师","好，还有问题吗？","over" };
    /*return*/ string[] cango = { "老师", "没有的话你可以走了", "over" };

    /*return*/ string[] chezhongtong = { "老师", "没有的话你可以走了", "over" };
    /*return*/ string[] luoyu = { "老师", "洛雨，挺好一姑娘啊","学习一般，但是人家努力的很，就凭这点你就比不过人家","想追人家你就要好好努力","啧，就你们那点小心思", "over" };
    /*return*/string[]  qimuyuan= { "老师", "启木原啊，怎么突然问起他来了？","虽然人家家里是有些困难，但是你不准对别人有歧视知道吗？","对了，你认识他的话帮我告诉他一声",
                                    "他上次参加的征文比赛获奖了，来我这拿一万块<Color=red>奖金</Color>","over" }; 
    /*return*/ string[]  a= { "老师", "没有的话你可以走了", "over" };
    public void ButtonChooseClassroomAnswer()
    {

        if (talkframe.stay == 2)//课室
        {

            talkframe.i = 1;
            talkframe.output = changeanswer();//选用一个回答
        }
        

    }


    string[] changeanswer()
    {
        if(answerquestion==true)
        {
            if (playerinput.text.Contains("新加坡"))
            {
                nexttalk = 3;
                answerquestion = false;
                return rightanswer;
            }
            else
            {
                answerquestion = false;
                return wronganswer;
            }
        }
      
        if(blamee==true)
        {
            if (playerinput.text.Contains("知道"))
            {
                blamee = false;
                question = true;
                return anyquestion;
            }
            else
                return sayagain;
        }
        if(question==true)
        {
            if (playerinput.text.Contains("没有"))
            {
                question = false;
                return cango;
            }
            if (playerinput.text.Contains("车中桐"))
            {
                
                return chezhongtong;
            }
            if (playerinput.text.Contains("洛雨"))
            {

                return luoyu;
            }
            if (playerinput.text.Contains("启木原"))
            {

                return qimuyuan;
            }
            else return null;
        }
        else return null;
    }
    //RandommAnswer()
    //{

    //}
}

