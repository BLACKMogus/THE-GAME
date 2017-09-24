using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class day1sport : MonoBehaviour {

    public Text playerinput;
    public static bool  Aiscome;
    bool namecall;
    int nexttalk = 0;

    void Start () {
        namecall = true;
	}
	/**/
  


	void Update () {
        if (talkframe.stay == 5)
        {
            starttalk(nexttalk);
            if (talkframe.havenext == true)
            {
                starttalk(nexttalk);
            }
        }
	}

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
        }
    }

    void starttalk(int i)
    {
        /*0*/string[] teachercome = { "体育老师", "人都到的差不多了吧","还有几分钟就上课了，我们先开始点名吧", "next" }; //  string[] cooker = { "", "", "", "" };
        /*1*/string[] teachercall = { "体育老师", "......", "over" };
        /*2*/string[] teachercall2 = { "体育老师", "车中桐！", "next" };
        /*3*/string[] chenotanswer = { "", "...", "...", "next" };
        /*4*/string[] teachercall3 = { "体育老师", "", "不在？有人知道他去哪了吗？", "next" };
        /*5*/string[] luanswer= { "鹿子野", "啊...啊那个", "他生病请假了......", "next" };
        /*6*/
        /*7*/
        /*8*/
        /*9*/
        /*10*/
        /*11*/
        /*12*/
        /*13*/
        /*14*/
        string[] cheanswer = { "车中桐", "到！", "next" };







        switch (i)
        {
            case 0:
             //   breathe[0] = string.Concat(playername.getname(), breathe[0]);
                talkframe.output = teachercome; stopchoose();
                break;
            case 1:
                teachercall[1] = string.Concat(teachercall[1], playername.getname());
                talkframe.output = teachercall; stopchoose();
                break;
            case 2:
                talkframe.output = teachercall2;
                talkframe.i = 1;
                if(Aiscome==false)
                {
                    nexttalk = 3;
                }
                else
                {

                }//车中桐到达的对话
                talkframe.havenext = false; ;
                break;
            case 3:

                break;
            default: break;
        }
    }


    void ChoseNext()
    {

    }
    void ChoseNext2()
    {

    }
    void stopchoose()
    {
        talkframe.i = 1;
        nexttalk++;
        talkframe.havenext = false;
    }
}
