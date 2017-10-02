using UnityEngine;
using System.Collections;

public class afterclass : MonoBehaviour {

    int nexttalk;
	void Start () {
        nexttalk = 0;

    }
	/* stay=6在 宿舍
    * stay=7在 第二次的食堂
    * stay=8在 足球场
    * stay=9在 书店
    */
    void Update () {
	   if(talkframe.stay==6)
        {
            if(talkframe.havenext==true)
            {
                DormChoseNext(nexttalk);
            }
        }
       else if (talkframe.i == 7)
        {
            if (talkframe.havenext == true)
            {
                CanteenChoseNext(nexttalk);
            }

        }
        else if (talkframe.i == 8)
        {
            FootballChoseNext(nexttalk);

        }
        else if (talkframe.i == 9)
        {
            BookChoseNext(nexttalk);
        }
    }
    void DormChoseNext(int i)
    {
        string[] zero = { "", "天色渐近黄昏，原本抱作一团的云四散而开", "在通往宿舍的路上到处都是刚刚下课的学生", "三五成群，熙熙攘攘","next",""};
        string[] one={"名字","啊，果然还是回宿舍洗个澡最好了","上完体育课满身是汗","next","","","","" };
        string[] two = { "!@#", "你知道今天中午发生了什么吗？", "next", "", "", "", "", "" };
        string[] three = { "$%^", "诶，什么什么？", "next", "", "", "", "", "" };
        string[] four = { "！@#", "好像有人被送去医院了", "救护车都开进了学校里面", "next", "", "", "", "" };
        string[] five = { "$%^", "具体情况呢？", "next", "", "", "", "", "" };
        string[] six = { "!@#", "这我就不知道啦！", "反正我也是听别人说的", "现场满地都是血", "next", "", "", "" };
        string[] seven = { "$%^", "哇这么恐怖的么", "next", "", "", "", "", "" };
        string[] eight = { "!@#", "还有还有，我跟你说......", "next", "" };
        string[] nine = { "", "路人渐行渐远，很快便无法再听清他们谈论的声音", "next", "", "", "", "" };
        string[] ten = { "名字", "意外事件啊...", "学校真是一个危险的地方......", "next", "", "", "", "" };

        switch (i)
        {
            case 0: talkframe.output = zero; stopchoose(); break;
            case 1: talkframe.output = one;stopchoose();break;
            case 2: talkframe.output =two; stopchoose(); break;
            case 3: talkframe.output = three; stopchoose(); break;
            case 4: talkframe.output = four; stopchoose(); break;
            case 5: talkframe.output = five; stopchoose(); break;
            case 6: talkframe.output = six; stopchoose(); break;
            case 7: talkframe.output = seven; stopchoose(); break;
            case 8: talkframe.output = eight; stopchoose(); break;
            case 9: talkframe.output = nine; stopchoose(); break;
            case 10: talkframe.output = ten; stopchoose();talkframe.go = 10;talkframe.gonext = true; break;
            default: break;
        }
    }

    void stopchoose()
    {
        talkframe.i = 1;
        nexttalk++;
        talkframe.havenext = false;
    }

    void CanteenChoseNext(int i)
    {
        string[] zero = { "", "下午的食堂比中午少了许多人", "大部分人都去校外吃了，毕竟旁边就有一条美食街", "", "next", "" };
        string[] one = { "名字", "刚刚运动完肚子快要饿死了......",  "next", "", "", "", "" };
        string[] two = { "!@#", "你知道今天中午发生了什么吗？", "next", "", "", "", "", "" };
        string[] three = { "$%^", "诶，什么什么？", "next", "", "", "", "", "" };
        string[] four = { "！@#", "好像有人被送去医院了", "救护车都开进了学校里面", "next", "", "", "", "" };
        string[] five = { "$%^", "具体情况呢？", "next", "", "", "", "", "" };
        string[] six = { "!@#", "这我就不知道啦！", "反正我也是听别人说的", "现场满地都是血", "next", "", "", "" };
        string[] seven = { "$%^", "哇这么恐怖的么", "next", "", "", "", "", "" };
        string[] eight = { "!@#", "还有还有，我跟你说......", "next", "" };
        string[] nine = { "", "他们从我身边擦肩而过","很快，食堂内喧闹的人声便掩盖了他们谈话的声音", "next", "", "", "", "" };
        string[] ten = { "名字", "意外事件啊...", "学校真是一个危险的地方......", "next", "", "", "", "" };
        switch (i)
        {
            case 0: talkframe.output = zero; stopchoose(); break;
            case 1: talkframe.output = one; stopchoose(); break;
            case 2: talkframe.output = two; stopchoose(); break;
            case 3: talkframe.output = three; stopchoose(); break;
            case 4: talkframe.output = four; stopchoose(); break;
            case 5: talkframe.output = five; stopchoose(); break;
            case 6: talkframe.output = six; stopchoose(); break;
            case 7: talkframe.output = seven; stopchoose(); break;
            case 8: talkframe.output = eight; stopchoose(); break;
            case 9: talkframe.output = nine; stopchoose(); break;
            case 10: talkframe.output = ten; stopchoose(); talkframe.go = 11; talkframe.gonext = true; break;
            default: break;
        }
            
    }

    void FootballChoseNext(int i)
    {
        string[] zero = { "", "太阳淡金色的亮光将足球场的一半切开来", "在跑道上的人们围绕着这片土地奔跑，身影忽明忽暗", "", "next", "" };
        string[] one = { "名字", "虽然刚才才上过体育课","不过，该跑还是要跑啊，唉", "next", "", "", "", "" };
        string[] two = { "!@#", "你知道今天中午发生了什么吗？", "next", "", "", "", "", "" };
        string[] three = { "$%^", "诶，什么什么？", "next", "", "", "", "", "" };
        string[] four = { "！@#", "好像有人被送去医院了", "救护车都开进了学校里面", "next", "", "", "", "" };
        string[] five = { "$%^", "具体情况呢？", "next", "", "", "", "", "" };
        string[] six = { "!@#", "这我就不知道啦！", "反正我也是听别人说的", "现场满地都是血", "next", "", "", "" };
        string[] seven = { "$%^", "哇这么恐怖的么", "next", "", "", "", "", "" };
        string[] eight = { "!@#", "还有还有，我跟你说......", "next", "" };
        string[] nine = { "", "两个女生一边散着步一边在聊天", "她们的声音一字不差的落入我的耳中", "next", "", "", "", "" };
        string[] ten = { "名字", "意外事件啊...", "学校真是一个危险的地方......", "next", "", "", "", "" };
        switch (i)
        {
            case 0: talkframe.output = zero; stopchoose(); break;
            case 1: talkframe.output = one; stopchoose(); break;
            case 2: talkframe.output = two; stopchoose(); break;
            case 3: talkframe.output = three; stopchoose(); break;
            case 4: talkframe.output = four; stopchoose(); break;
            case 5: talkframe.output = five; stopchoose(); break;
            case 6: talkframe.output = six; stopchoose(); break;
            case 7: talkframe.output = seven; stopchoose(); break;
            case 8: talkframe.output = eight; stopchoose(); break;
            case 9: talkframe.output = nine; stopchoose(); break;
            case 10: talkframe.output = ten; stopchoose(); talkframe.go = 12; talkframe.gonext = true; break;
            default: break;

        }

    }
    void BookChoseNext(int i)
    {
        string[] zero = { "", "听鹿子野这么说才过来看一下的", "但是这个书店意外的不错啊，还挺精致的", "", "next", "" };
        string[] one = { "名字", "虽然刚才才上过体育课", "不过，该跑还是要跑啊，唉", "next", "", "", "", "" };
        string[] two = { "!@#", "你知道今天中午发生了什么吗？", "next", "", "", "", "", "" };
        string[] three = { "$%^", "诶，什么什么？", "next", "", "", "", "", "" };
        string[] four = { "！@#", "好像有人被送去医院了", "救护车都开进了学校里面", "next", "", "", "", "" };
        string[] five = { "$%^", "具体情况呢？", "next", "", "", "", "", "" };
        string[] six = { "!@#", "这我就不知道啦！", "反正我也是听别人说的", "现场满地都是血", "next", "", "", "" };
        string[] seven = { "$%^", "哇这么恐怖的么", "next", "", "", "", "", "" };
        string[] eight = { "!@#", "还有还有，我跟你说......", "next", "" };
        string[] nine = { "", "两个女生一边散着步一边在聊天", "她们的声音一字不差的落入我的耳中", "next", "", "", "", "" };
        string[] ten = { "名字", "意外事件啊...", "学校真是一个危险的地方......", "next", "", "", "", "" };
        switch (i)
        {
            case 0: talkframe.output = zero; stopchoose(); break;
            case 1: talkframe.output = one; stopchoose(); break;
            case 2: talkframe.output = two; stopchoose(); break;
            case 3: talkframe.output = three; stopchoose(); break;
            case 4: talkframe.output = four; stopchoose(); break;
            case 5: talkframe.output = five; stopchoose(); break;
            case 6: talkframe.output = six; stopchoose(); break;
            case 7: talkframe.output = seven; stopchoose(); break;
            case 8: talkframe.output = eight; stopchoose(); break;
            case 9: talkframe.output = nine; stopchoose(); break;
            case 10: talkframe.output = ten; stopchoose(); talkframe.go = 13; talkframe.gonext = true; break;
            default: break;

        }

    }
}
