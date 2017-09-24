using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class day1class : MonoBehaviour
{
    public Text playerinput;
    static bool first;
    static int nexttalk;
    static bool blamee;
    static bool question;
    static bool answerquestion;
    static bool cheaskq;
    static bool askself;
    void Start()
    {
        first = true;
        blamee = false;
        question = false;
        answerquestion = false;
        cheaskq = false;
        askself = false;
        nexttalk = 0;
    }
    public static void setfalse()
    {
        first = true;
        blamee = false;
        question = false;
        answerquestion = false;
        cheaskq = false;
        askself = false;
        nexttalk = 0;
    }


    void Update()
    {

        if (talkframe.stay == 2)//在校门口
        {
            if (first == true)
            {
                sleep[0] = string.Concat(sleep[0], playername.getname());
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
            teacherask[1] = string.Concat(playername.getname(), teacherask[1]);
            teacherask[2] = string.Concat(playername.getname(), teacherask[2]);
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
        else if (nexttalk == 3)
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

        { talkframe.output = blame;
            stopchoose(); }
        else if (nexttalk == 6)

        { talkframe.output = wait;
            stopchoose(); }
        else if (nexttalk == 7)

        { talkframe.output = blameconti;
            blamee = true;
            stopchoose(); }

        else if (nexttalk == 8)
        { talkframe.output = continueclass;
            stopchoose(); }
        else if (nexttalk == 9)
        { talkframe.output = bell;
            stopchoose(); }
        else if (nexttalk == 10)
        { talkframe.output = notblame;
            stopchoose(); }
        else if (nexttalk == 11)
        { talkframe.output = cheask;
            cheaskq = true;
            stopchoose(); }
        else if (nexttalk == 12)
        {
            talkframe.output = chego;
            stopchoose();
        }
        else if (nexttalk == 13)
        {
            talkframe.output = chedes;
            askself = true;
            stopchoose();
        }
    }
    void stopchoose()
    {
        talkframe.i = 1;
        nexttalk++;
        talkframe.havenext = false;
    }



    /*开场话*/
    string[] sleep = { "", "zzzz", "next" };// "zzzzzzzz", "zzzzzzzzzzz",             { "车中桐", "", "", "", "", "next" };
                                            /*0*/
   /*0*/ string[] teacherask = { "老师", "  ", "  !", "起来回答一下这个问题", "over" };//开头 
                                                                      /*return*/
    string[] wronganswer = { "老师", "搞事？搞事？", "next" };//  "不会做还不好好听课", "下课后给我留下来", "车中桐，你来回答一下",

    //回答错误的线
    /*1*/
    string[] cheanswer = { "车中桐", "Singapore的意思是<Color=red>新加坡</Color>", "next" };
    /*2*/
    string[] teacherboost = { "老师", "嗯，很好,坐下吧", "另外，你待会下课留一下","next" };//"我在这里顺便就说一下啊", "这次分班考试中车中桐同学的总分是<Color=red>年级第一</Color>", "啊，这和他一直保持勤奋好学是脱不开干系的", " “  名字  ”  ，你多学学人家，知道吗？", 
    //回答正确的线
    string[] rightanswer = { "老师", "嗯，还不错，坐下吧", "next" };
    /*3*/    /*8*/
    string[] continueclass = { "老师", "我们继续上课","next" };//  "这道题嘛，首先A肯定是错的", "B明显不对", "C一看就不符合题意", "所以选D，应该都清楚了吧，不会的请举手", "没有是吧，好，下一题......", 

    /*4*/    /*9*/
    string[] bell = { "铃声", "3125,5132", "next" };
    /*------------------------------------------------------------------------------------------------------------------------------*/
    /*10*/
    string[] notblame = { "老师", "唉~欢乐的时光总是短暂的", "next" };// "今天破例就直接下课吧", "大家都早点去吃饭",
    /*11*/
    string[] cheask = { "车中桐", "你刚才睡着都能答对啊，那么6的吗", "over" };// "话说我早饭都没吃，快饿死了，我们现在哪吃啊",
    /*12*/
    string[] shitang = { "车中桐", "也行吧，反正好久没吃食堂了", " ", "怎么了，还不走？还有事情？", "over" };
    string[] toshitang = { "车中桐", "算了...还不如食堂呢", "食堂近一点，吃的也多 ", "走吧走吧赶快走吧", "  ", "怎么了？还有事情？", "over" };
    /*------------------------------------------------------------------------------------------------------------------------------*/
    /*5*/
    string[] blame = { "老师", "唉~欢乐的时光总是短暂的", "今天破例就直接下课吧", "大家都早点去吃饭", "“名字，你过来", "next" };
    /*6*/
    string[] wait = { "车中桐", "我在外面等你吃饭哈", "next" };
    /*7*/
    string[] blameconti = { "老师", "车中桐和你是同桌", "over" }; //"多学学他的优点", "虽然上课睡觉是小事", "但是长期下去也会影响学习", "下次再看到你睡觉，就让你去后面罚站", "知道了吗？",
    //回答不知道
    /*return*/
    string[] sayagain = { "老师", "看来你还是没开窍，好，那我再说一遍","over" };// "车中桐和你是同桌", "多学学他的优点", "虽然上课睡觉是小事", "但是长期下去也会影响学习","下次再看到你睡觉，就让你去后面罚站", "知道了吗？", 
    //回答知道
    /*8*/
    string[] anyquestion = { "老师", "好，还有其它问题吗？", "over" };

    /*回答其它答案*/
    /*return*/
    string[] otheranswer = { "老师", "净问这些无聊的问题", "over" };
    /*return*/
    string[] cango = { "老师", "没有的话你可以走了", "next" };
    /*12*/
    string[] chego = { "车中桐", "抱歉，我有事先走一步，你自己去吃午饭吧", "next" };
    /*13s*/
    string[] chedes = { " ", "说完，他便神色紧张地跑走了", "那么，现在只能自己去吃饭了","去哪呢","over" };


    /*return*/
    string[] chezhongtong = { "老师", "没有的话你可以走了", "over" };
    /*return*/
    string[] luoyu = { "老师", "洛雨，挺好一姑娘啊", "学习一般，但是人家努力的很，就凭这点你就比不过人家", "想追人家你就要好好努力", "啧，就你们那点小心思", "over" };
    /*return*/
    string[] qimuyuan = { "老师", "启木原啊，怎么突然问起他来了？","虽然人家家里是有些困难，但是你不准对别人有歧视知道吗？","对了，你认识他的话帮我告诉他一声",
                                    "他上次参加的征文比赛获奖了，来我这拿一万块<Color=red>奖金</Color>","over" };
    /*return*/
   
    public void ButtonChooseClassroomAnswer()
    {

        if (talkframe.stay == 2)//课室
        {

            talkframe.i = 1;
            talkframe.output = changeanswer();//选用一个回答
        }


    }

    string[] answerclassquestion()
    {
        if (playerinput.text.Contains("新加坡"))
        {
            nexttalk = 8;
            talkframe.go = 4;//答对去咖啡屋
            answerquestion = false;
            talkframe.havenext = false;
            return rightanswer;
        }
        else
        {
            talkframe.go = 3; //答错去食堂
            answerquestion = false;
            return wronganswer;
        }
    } //新加坡问题
    string[] answerblamequestion()
    {
        if (playerinput.text.Contains("知道"))
        {
            blamee = false;
            question = true;
            return anyquestion;
        }
        else
            return sayagain;
    }//教训问题
    string[] answerotherquestion()
    {
        if (playerinput.text.Contains("没有"))
        {
            question = false;
            nexttalk = 12;
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
        else return otheranswer;
    }//人名问题
    string[] answerchequestion()
    {
        if (playerinput.text.Contains("食堂"))
        {
            talkframe.gonext = true;
            return shitang;
        }
        else
        {
            talkframe.gonext = true;
            return toshitang;
        }
    }//去哪吃问题
    string[] askme()
    {
        string[] shitangg = { "  ", "唉，懒得去其他地方了，就去食堂吧", "  ", "  ", "等等，还是再想想吧", "over" };
        string[] notshitang = { "  ", "还不如去<Color=red>食堂</Color>呢", "over" };
        if (playerinput.text.Contains("食堂"))
            {
            talkframe.gonext = true;
            askself = false;
            return shitangg;
        }
        else return notshitang;
    }

    string[] changeanswer()
    {
        string[] getstring;
        if (answerquestion == true)//回答上课的问题
        {
          getstring=  answerclassquestion();
            return getstring;
        }

        if (blamee == true)//回答老师责问
        {
            getstring = answerblamequestion();
            return getstring;
        }
        if (question == true)//回答还有什么问题？
        {
            getstring = answerotherquestion();
            return getstring;
        }
        if (cheaskq == true)
        {
            getstring = answerchequestion();
            return getstring;

        }
        else if(askself==true)
        {
            getstring = askme();
            return getstring;
        }
        else return null;
    }


}

