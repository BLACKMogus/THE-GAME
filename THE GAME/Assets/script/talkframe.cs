﻿using UnityEngine;
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
    public static bool gonext;
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
     *stay=3在  食堂
     *stay=4在  咖啡屋
     *stay=5在  篮球场
    * stay=6在 宿舍
    * stay=7在  第二次的食堂
    * stay=8在 足球场
    * stay=9在 书店
    * stay=10在钥匙妹
    * 
    * 
    * stay=20 晚修
     */
    public static int go;
    /*
   * go=2   校门→课室
   * go=3   课室→食堂
   * go=4   课室→(食堂)路过咖啡屋
   * go=5   食堂→篮球场
   * go=6   篮球场→宿舍
   * go=7   篮球场→食堂
   * go=8   篮球场→足球场
   * go=9   篮球场→叮当达
   * go=10  宿舍→晚修
   * go=11  食堂→晚修
   * go=12  足球场→晚修
   * go=13  叮当达→晚修
   * go=20   咖啡屋→篮球场
   * 
   */

    public Text text;
    public Text namee;
    public GameObject lefttalkframe;
   

    public static string[] output;

    void Start() {
        havenext = true;
        gonext = false;
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
       if(gonext==false)               //控制前往下一个地图的按钮
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
       // isdelay = false;   正式解除
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
          
            namee.text = output[0];
            text.DOText(output[i],  1f, true, ScrambleMode.Custom, " ");//字体出现时间为字数乘以0.3s
           // isdelay = false;
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













