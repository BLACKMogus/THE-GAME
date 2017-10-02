using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class day1sport : MonoBehaviour {

    public Text playerinput;
    public static bool Aiscome;

    static bool namecall;
    static int nexttalk;
    static bool ask;
    static int asknum;
    static bool gowhere;
    static bool cheiscome;
//    int descripnum;//描写的序号

    void Start() {
        namecall = true;
        Aiscome = false;
        nexttalk = 0;
        ask = false;
        gowhere = false;
        asknum = 0;
        cheiscome = false;
        //descripnum = 0;
    }
    public static void SetFalse()
    {
        namecall = true;
        Aiscome = false;
        nexttalk = 0;
        ask = false;
        gowhere = false;
        asknum = 0;
        cheiscome = false;
    }


    void Update() {
        if (talkframe.stay == 5)
        {
            if (talkframe.havenext == true)
            {
                starttalk(nexttalk);

            }
        }
    }
    string[] where = { "","有这样的地方么。。。","over",};

    public void ButtonChooseAnswer()
    {
        if (talkframe.stay == 5)
        {
            if (namecall == true)
            {
                talkframe.i = 1;
                 starttalk(2);
                namecall = false;
            }
            else if(ask==true)
            {
                if (asknum < 2)//正式改成4
                { if (playerinput.text.Contains("不知道"))
                    { asknum++;
                        starttalk(100);  }
                    else if (playerinput.text.Contains("车中桐"))
                    { asknum++;
                        starttalk(101); }
                    else if (playerinput.text.Contains("洛芷雨"))
                    { asknum++;
                        starttalk(102);}
                    else
                    { asknum++;
                        starttalk(200); }
                }
                else starttalk(11);
            }
            else if(gowhere==true)
            {
                if (playerinput.text.Contains("宿舍"))
                {
                    starttalk(201);
                    talkframe.go = 6;
                    talkframe.gonext = true;
                 
   
        
                }
                else if (playerinput.text.Contains("食堂")|| playerinput.text.Contains("饭堂"))
                {
                    talkframe.go = 7;
                    talkframe.gonext = true;
                }
                else if (playerinput.text.Contains("足球场"))
                {
                    talkframe.go = 8;
                    talkframe.gonext = true;
                }
                else if (playerinput.text.Contains("叮当达"))
                {
                    talkframe.go = 9;
                    talkframe.gonext = true;
                }
                else talkframe.output = where;
            }
        }
    }

    void starttalk(int i)
    {
        /*0*/string[] zero = { "体育老师", "人都到的差不多了吧","还有几分钟就上课了，我们先开始点名吧", "next" }; //  string[] cooker = { "", "", "", "" };
        /*1*/string[] one = { "体育老师", "......", "over" };
        /*2*/string[] two = { "体育老师", "车中桐！", "next" };
        //车中桐没到的时间线
        /*3*/string[] three = { "", "...", "...", "next" };
        /*4*/string[] four = { "体育老师", "", "不在？有人知道他去哪了吗？", "next" };
        /*5*/string[] five= { "鹿子野", "啊...啊...勒个", "他生病请假了......", "next" };
        /*6*/string[] six = { "体育老师", "请假？", "让他下次把请假条交过来","鹿子野！", "next" };
        /*7*/string[] seven= { "鹿子野", "这里这里！",  "next" };
        /*8*/string[] eight = { "体育老师", "车中桐没来的话", "就你们两个先去拿球吧","next" }; //描写 拿球
        /*9*/string[] nine= { "", "然后，老师把钥匙给了鹿子野", "我便跟在他后面去器材室拿球","平常我跟他的关系也只是一般", "此时他凑上来和我说话", "next" };
        /*10*/string[] ten= { "鹿子野", "诶诶，问你件事儿", "平常桐子不是跟你挺好的么？", "晓不晓得他去哪了", "over" };
        /*11*/string[] eleven = { "体育老师","你们两个说什么呢磨磨蹭蹭的！动作快一点！","next"};
        /*12*/
        string[] twelve = { "鹿子野", "来了来了!", "next" };
        /*13*/
        string[] thirteen = { "", "大声的应完之后", "他又回头小声地对我说，你看，像不像正在护送运载目标","next" };
        /*14*/
        string[] fourteen = { "”名字“", "......", "next" };
        /*15*/
        string[] fifteen = { "体育老师","这节课你们分成小组自由练习吧","...", "......", ".........","next" };
        /*16*/
        string[] sixteen = { "铃声", "31255132", "next" };
        /*17*/
        string[] seventeen = { "体育老师", "好，集合！", "下课！", "next" };
        /*18*/
        string[] eighteen = { "","终于下课了...","那么，要去哪呢","over",};
        //车中桐到的时间线
        string[] cheanswer = { "车中桐", "到！", "next" };




        /*return*/
        /*100*/
        string[] onehundred = { "鹿子野","不是吧，你都不晓得...","我愣是没见过他逃过课","我饭卡还在他手上拿起的，他不来我晚上哪么吃嘛......","over"};
        /*101*/
        string[] chezhongtong = { "鹿子野", "你说桐子啊", "虽然我们是舍友...但是", "嗯...哪么说，成绩好，人又帅，上课就算是睡觉也拿得到年级前十的学霸","勒种操作学不来学不来", "over" };
        /*102*/
        string[] luozhiyu = { "鹿子野", "勒个我晓得", "我们是同一节选修的","桐子也是一起的嘛","他没有告诉你？", "他还让我去帮忙要联系方式","当然我确实是要到了", "next" };
        /*103*/
        string[] l1 = { "", "他露出一脸很骄傲的表情", "over" };
        /*104*/
        /*200*/
        string[] otherask={ "鹿子野", "你再说啥子哦", "我啷个听得懂嗦", "over"};
        string[] dorm = { "", "先回宿舍一趟吧","","", "要去哪呢", "over" };

        switch (i)
        {
            case 0:
             //   breathe[0] = string.Concat(playername.getname(), breathe[0]);
                talkframe.output = zero; stopchoose();
                break;
            case 1:
                one[1] = string.Concat(one[1], playername.getname());
                talkframe.output = one; stopchoose();
                break;
            case 2:
                talkframe.output = two;
                talkframe.i = 1;
                talkframe.havenext = false;
                if(Aiscome==false)
                {//车中桐没到达
                    nexttalk = 3;
                }
                else
                {
                    nexttalk = 10;// 不清楚
                }//车中桐到达的对话
                talkframe.havenext = false; ;
                break;
            case 3:
                talkframe.output = three;stopchoose();break;
            case 4:
                talkframe.output = four; stopchoose(); break;
            case 5:
                talkframe.output = five; stopchoose(); break;
            case 6:
                talkframe.output = six; stopchoose(); break;
            case 7:
                talkframe.output = seven; stopchoose(); break;
            case 8:
                talkframe.output = eight; stopchoose(); break;
            case 9:
                talkframe.output = nine; stopchoose(); break;
            case 10:
                talkframe.output =ten; stopchoose();ask = true; break;
            case 11:
                talkframe.output = eleven; stopchoose(); ask = false; gowhere = true; nexttalk = 12 ; break;
            case 12:
                talkframe.output = twelve; stopchoose(); break;
            case 13:
                talkframe.output = thirteen; stopchoose(); break;
            case 14:
                talkframe.output = fourteen; stopchoose(); break;
            case 15:
                talkframe.output = fifteen; stopchoose(); break;
            case 16:
                talkframe.output = sixteen; stopchoose(); break;
            case 17:
                talkframe.output = seventeen; stopchoose(); break;
            case 18:
                talkframe.output = eighteen; stopchoose();  break;


            case 100:
                talkframe.output = onehundred; stopchoose(); break;
            case 101:
                talkframe.output = chezhongtong; stopchoose(); break;
            case 102:
                talkframe.output = luozhiyu; stopchoose();nexttalk = 103; break;

            case 200:talkframe.output = otherask;stopchoose(); break;
            case 201: talkframe.output = dorm; stopchoose(); nexttalk = 18; break;

            default: break;
        }
    }


    //void description(int i)
    //{
       


    //    switch (i)
    //    {
    //        case 0: talkframe.output = zero;stopchoose();descri = false; break;
    //        default:break;
    //    }
    //}
    void stopchoose()
    {
        talkframe.i = 1;
        nexttalk++;
        talkframe.havenext = false;
    }
}
