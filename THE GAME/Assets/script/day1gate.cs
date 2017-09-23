using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class day1gate : MonoBehaviour
{

   
    void Start()
    {

    }
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (talkframe.stay == 1)//在校门口
        {
            if (string.IsNullOrEmpty(playerinput.text))
            { talkframe.output = morning; }
          
        }
    }

    string keyword = "教室";
    string[] morning = { "车中桐","早啊...", "一大早的真是困死我了","啊~啊~~~", "over" };//开头
    string[] noon = { "车中桐", "你没睡醒吧...现在是早上啊", "over" };//午。晚
    string[] breakfast = { "车中桐", "还没吃呢...赶着上课啊", "over" };//早餐
    string[] che= { "车中桐", "我？我怎么了", "over" };

    string[] shuai = { "车中桐", "啊~没想到我隐藏的这么深还是被你发现了", "over" };
    string[] sha  = { "车中桐", "你才傻呢", "over" };

    string[] nulll;
    string[] classroom = { "车中桐", "快走，要打铃了", "over" };//按钮显现
    string[] answer = { "车中桐", "我看看啊，现在是......", "哇还有不到三分钟了", "快快快", "over" };//正确答案
    
    public Text playerinput;

    public void ButtonChooseAnswer()
    {
        talkframe.i = 1;
        if (talkframe.stay == 1)//在校门口
        { 
          
           talkframe.output = change();//选用一个回答
        }
      
    }
    string[] change()
    {
            if (playerinput.text.Contains("午") || playerinput.text.Contains("晚"))
            {
                return noon;

            }
            if (playerinput.text.Contains("早餐"))
            {
                return breakfast;
            }
            if (playerinput.text.Contains("早") || playerinput.text.Contains("哦") || playerinput.text.Contains("好"))
            {
            string.Concat(answer[3], keyword);
                return answer;
            }
            if (playerinput.text.Contains("车中桐"))
            {
                return che;   
            }
            if (playerinput.text.Contains("课") || playerinput.text.Contains("教"))
            {
                talkframe.go = 2;
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
    string[] E = { "车中桐", "这只是第一关哪来那么多关键词给你试      ╭(╯^╰)╮","你怎么不试试我的名字", "over" };//随机回答

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