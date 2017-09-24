using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class playername : MonoBehaviour {

    private static playername instance=new playername();//正式改掉 去掉等于后面
    Text playernamee;//单例里的玩家名字
    int times=0;
    string pname;
    public Text inputcontent;//输入的内容
    public Text framecontent;//对话框显示内容
    bool isdelay;//延迟点击
    bool thefirst;//第一次记录名字
    bool continu;

    void Awake()
    {
        //  instance = this; 正式解除

        thefirst = true;
    }
    void Start()
    {
      
        isdelay = false;  
        continu = true;
    }

    public static string getname()
    {
        instance.pname = "黑莫格斯"; //正式删除
        return instance.pname;
    }
    public static int gettimes()
    {
           return instance.times;
    }
    public static void addone()
    {
        instance.times += 1;
    }

    int q;
    int i = 0;
    string[] talk ={"我让你输入真的输入啊","随便吧,反正接下去你想怎样就怎样啦","给你一点提示吧","红色的词语是关键词，可以用在某个地方哦"
            ,"比如<Color=red>提示</Color>","over"};
    string[] tips = { "提示什么，不存在的，别想了","不过呢，其他的时候就凭借你的直觉来吧", "哎呀没什么要说的了", "能不能通关就看缘分吧 ", "溜了溜了","",
                     "","","...","干嘛啊...","真的没什么要说的了","...哇你还敢动我","再动一下试试？","有种再动一下","我告诉你！我！我可是！我可是游戏管理员",
                    "信不信我让你通不了关？","不要来烦我啊！","你不要过来啊！","我要睡觉啦！","那个辣鸡程序员通宵打代码把我累得要死",
                     "啊，什么，你想和我做朋友吗","真的吗，真的吗","这是我的ip地址:192.168.10.222","有空还请来我家玩",
                     "好了不说了，我要休息了，你自己玩吧","","","","","","不用再点了，后面没内容了","这次是真的","不信的话就继续点吧",
                     "悄悄告诉你一句，其实点击量到达1000会有一个成就","嗯，（认真脸）"};

    string[] ing;
    void Update()
    {

        if (thefirst == false)
        {
            if (isdelay==true)
          {
              if (continu==true)
              {  
                  if (Input.GetMouseButtonDown(0))
                  { q = ing[i].Length;
                    framecontent.DOText(ing[i], q * 0.1f, true, ScrambleMode.Custom, " ");
                    i++;
                    isdelay = false;
                    StartCoroutine("delay");
                    if(ing[i].Contains("over"))
                        {
                            continu = false;
                        }
                   }
              }
          }
       }
    }

    public void ButtonConfirm()
    {
        if(thefirst==true)
        {
            ing = talk;
            playernamee = inputcontent;
            pname = playernamee.text;
            thefirst = false;
            StartCoroutine("delay");          
        }
        if(inputcontent.text.Contains("提示"))
        {
            continu = true;
            ing = tips;
            i = 0;
        }
        if (inputcontent.text.Contains("开始")|| inputcontent.text.Contains("art")|| inputcontent.text.Contains("gin"))
        {
            SceneManager.LoadScene(1);
        }
    }

    IEnumerator delay()
    {

        yield return new WaitForSeconds(1.5f);
        isdelay = true;
    }

}
