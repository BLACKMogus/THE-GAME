using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;
public class day2coffee : MonoBehaviour {
    public Text playerinput;
    public GameObject phone;
    static  bool entercoffee;
    static bool delete;
    static bool follow;
    static bool gotocanteen;
    static int nexttalk;

	void Start () {
        entercoffee = false;
        delete = false;
        follow = false;
        gotocanteen = false;
        nexttalk = 0;
        phone.transform.Translate(new Vector2(0,  Screen.height/2));
    }
   public static void Setfalse()
    {
       entercoffee=false;
       delete=false;
       follow=false;
       gotocanteen=false;
       nexttalk=0;
    }
	
	// Update is called once per frame
	void Update () {
        if (talkframe.stay == (4))
        {
            if (talkframe.havenext == true)
            {
               ChoseNext(nexttalk);
                talkframe.i = 1;
                talkframe.havenext = false;
            }
        }
    }
 

    void ChoseNext(int i)
    {
        //1
        string[] zero = { "车中桐", "诶等等，等等，我好像看到一个人", "走走走", "over" };
        string[] one = { "", "", "", "" };
        string[] two = { "", "", "", "" };
        string[] three = { "", "", "", "" };
        string[] four = { "", "", "", "" };
        string[] five = { "", "", "", "" };
        string[] six = { "", "", "", "" };
        string[] twenty= { "车中桐", "啊，我没事", "next", "" };

        string[] twentyone = { "", "这时候他掏出手机看了看", "然后在混乱中人突然不见了","next" };
        string[] twentytwo = { "", "诶他人呢？", "刚才还在这的","下次要获得他手机看看", "next"};
        string[] twentythree = { "名字", "现在去哪呢", "  ", "over" };

        //没有借手机
        string[]  onehundred= { "车中桐", "我先过去了，你快点跟过来", "over", "" };//answer
        string[] onehundredone = { "名字", "...", "over", "" };
        //借手机删除短信
        string[] fifty = { "名字", "你手机借我打个电话", "next", "" };
        string[] fiftyone = { "车中桐","啊，借手机啊", "给你", "那我先进去了", "next", "", "", "", "", "" };
        string[] fiftytwo = { "", "拿着车中桐的手机，过了一会儿收到了短信", "next", "" };
        string[] fiftythree = { "", "", "next", "" };
        string[] fiftyfour = { "名字", "这是什么意思", "next", "" };
        string[] fiftyfive = { "", "要不要删除呢", "over", "","" };
        string[] fiftysix = { "", "果然还是删除了吧", "next", "" };
        string[] fiftyseven = { "", "  还你手机，去哪", "over", "" };
        string[] lesspeople = { "", "  现在人应该会少一点了","","", "over", "" };
        string[] gocanteen = { "车中桐", "其他地方懒得去了", "就去食堂吧", "唉","over" };


        string[] fiftyeight = { "", "", "next", "" };
        string[] fiftynine = { "", "", "next", "" };
        string[] sixty = { "", "", "next", "" };
        string[] sixtyone = { "", "", "next", "" };
        string[] sixtytwo = { "", "", "next", "" };
        string[] sixtythree = { "", "", "next", "" };
        string[] sixtyfour = { "", "", "next", "" };
        //没有删除短信
        string[] eighty = { "", "果然还是先不删", "跟着他去看看", "next" };
        string[] eightyone = { "", "车中桐回来，看手机，走了，我们要去哪", "over", "" };

        string[] onehundredten = { "", "果然还是跟着他去看看","","", "over", "" };
        string[] onehundredeleven = { "", "不然要去哪嘛", "", "", "over", "" };
        switch (i)   
        {
            //没有借手机的剧情
            case 0: talkframe.output = zero; nexttalk++ ; entercoffee = true; break;
            case 1: talkframe.output = one; nexttalk++; break;
            case 2: talkframe.output = two; nexttalk++; break;
            case 3: talkframe.output = three; nexttalk++; break;
            case 4: talkframe.output = four; nexttalk++; break;
            case 5: talkframe.output = five; nexttalk++; break;
            case 6: talkframe.output = six; nexttalk++; break;
            case 20: talkframe.output = twenty; nexttalk++; break;
            case 21: talkframe.output = twentyone; nexttalk++; break;
            case 22: talkframe.output = twentytwo; nexttalk++; break;

            //case 24: talkframe.output = twentyfour; nexttalk++; break;
            //case 25: talkframe.output = twentyfive; nexttalk++; break;
            //case 26: talkframe.output = twentysix; nexttalk++; break;
            //case 30: talkframe.output = thirty; nexttalk = 31; break;
            
            //借了手机
            case 50: talkframe.output = fifty; nexttalk=51; break;
            case 51: talkframe.output = fiftyone; nexttalk++; break;
            case 52: talkframe.output = fiftytwo; nexttalk++; break;
            case 53: talkframe.output = fiftythree; nexttalk++;ShowPhone(); delete = true; break;
            case 54: talkframe.output = fiftyfour; nexttalk++; break;
            case 55: talkframe.output = fiftyfive; nexttalk++; break;
            case 56: talkframe.output = fiftysix; nexttalk++; break;
            case 57: talkframe.output = fiftyseven; nexttalk++;BackPhone(); gotocanteen = true; break;
            case 80: talkframe.output = eighty; nexttalk=81; break;
            case 81: talkframe.output =eightyone; nexttalk++; break;
             
            case 100: talkframe.output = onehundred; nexttalk=101; break;
            case 101: talkframe.output = onehundredone; nexttalk=1; break;

            case 110: talkframe.output = onehundredten; nexttalk++; break;
            case 130: talkframe.output = gocanteen; nexttalk++; break;
            case 131:talkframe.output = lesspeople; nexttalk++; break;
            default: break; 

        }
    }
    public void ButtonCoffee()
    {
        if (entercoffee == true)
        {
            if (playerinput.text.Contains("好"))
            {
                ChoseNext(nexttalk);
                entercoffee = false;
                talkframe.i = 1;
             
            }
            else if (playerinput.text.Contains("手机"))
            {
                ChoseNext(50);
                entercoffee = false;
                talkframe.i = 1;
            }
            else
            {
                ChoseNext(100);
                entercoffee = false;
                talkframe.i = 1;
            }

        }
        else if(delete==true)
        {

            if (playerinput.text.Contains("删除"))
            {
                talkframe.i = 1;
                ChoseNext(nexttalk);
                delete = false;
            }
            else if (playerinput.text.Contains("不删"))
            {
                talkframe.i = 1;
                ChoseNext(80);
                delete = false;
            }
            else
            {
                talkframe.i = 1;
                ChoseNext(55);
            }
        }

        else if (follow == true)
        {
            if (playerinput.text.Contains("钥匙妹"))
            {
                talkframe.i = 1;
                talkframe.go = 15;
                talkframe.gonext = true;
                ChoseNext(110);
            }
            else
                talkframe.i = 1;
                ChoseNext(111);
        }
        else if(gotocanteen==true)
        {
            if (playerinput.text.Contains("食堂"))
            {
                talkframe.go = 16;
                talkframe.gonext = true;
                talkframe.i = 1;
                ChoseNext(131);
            }
            else
                talkframe.i = 1;
               ChoseNext(130);
 
        }
    }
    void ShowPhone()
    {
        phone.transform.DOLocalMoveY(0, 2);
    }
    void BackPhone()
    {
        phone.transform.DOLocalMoveY(Screen.height, 2);
    }
}
