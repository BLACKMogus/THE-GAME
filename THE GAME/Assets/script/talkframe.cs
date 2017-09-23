using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;
public class talkframe : MonoBehaviour {
    public static int i = 1;
    public GameObject mask;//对话框
    public static int q = 0;
    public static bool isdelay;
    public static bool stopcoroutine;
    public static bool havenext;
    public GameObject nextscene;//去下一个场景的按钮
    Tween a;
    //public enum state
    //{
    //    gate,
    //    classroom,
    //    canteen,
    //    playground,

    //}
    public static int stay;
    /*
     *stay=1在  门口 
     *stay=2在  课室
     *stay=3在  小道
     *stay=4在  咖啡屋
     * 
     * 
     */
    public static int go;
    /*
   * go=2去课室
   * go=3去小道
   * go=4去咖啡屋
   * 
   * 
   */

    public Text text;
    public Text namee;
    public GameObject lefttalkframe;
   

    public static string[] output;

    void Start() {
        havenext = false;
        isdelay = true;
        stay = 1;
        go = 0;
        lefttalkframe.SetActive(false);
    }
  

    void Update() {
      if(stopcoroutine==true)
        {
            StopCoroutine("delay");
        }
        outputtalk();          //输出对话内容
       if(go==0)               //控制前往下一个地图的按钮
        {
            nextscene.SetActive(false);
        }
       else
        {
            nextscene.SetActive(true);
        }
    }

    public void ButtonDispearArrow()//输入框按钮按下后消失
    {
        mask.SetActive(false);
        ButtonShowTheWord();
    }

    public void ButtonShowTheWord()//按下输入框按钮后输出第一行
    {
     
        text.DOText(output[i], 1f, true, ScrambleMode.Custom, " ");//字体出现时间为字数乘以0.3s
        i++;
        isdelay = false;
        StartCoroutine("delay");
    }


    void typeword()
    {
        if (output[i].Contains("over"))//如果数组over了则使输入框出现
        {
            mask.SetActive(true);
        }
        else if(output[i].Contains("next"))
        {
            havenext=true;
        }
        else
        {
            q = output[i].Length;      //q为当前这句话的字数
            Debug.Log(q);
            namee.text = output[0];
            text.DOText(output[i],  1f, true, ScrambleMode.Custom, " ");//字体出现时间为字数乘以0.3s
            isdelay = false;
            i++;
            StartCoroutine("delay");
        }
    }


    void outputtalk()//输出对话内容
    {
      if (isdelay == true)//延迟点击两秒
      { if (Input.GetMouseButtonDown(0))
         {    if (lefttalkframe.activeSelf == true)
                  {
                    typeword();
                  }
            else  {
                    lefttalkframe.SetActive(true);
                    typeword();
                }
         }
      }
     
    }
 
    IEnumerator  delay()
    {

        yield return new WaitForSeconds(1.5f);
        isdelay = true;
    }

}













