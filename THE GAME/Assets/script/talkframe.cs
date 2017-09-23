using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;
public class talkframe : MonoBehaviour {
    public static int i = 1;
    public GameObject mask;//对话框
    public static int q = 0;
    bool isdelay = true;
    public GameObject nextscene;//去下一个场景的按钮
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
        //  map = state.gate;//初始处于校门的场景
        stay = 1;
        go = 0;
        lefttalkframe.SetActive(false);
    }
  

    void Update() {
      
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
     
        text.DOText(output[i], q * 0.3f, true, ScrambleMode.Custom, " ");//字体出现时间为字数乘以0.3s
        i++;
        isdelay = false;
        StartCoroutine("delay");
    }

    //public void ButtonGoNextScene()
    //{
    //    if(go==2)
    //    {

    //    }
    //}

    void outputtalk()//输出对话内容
    {
      if (isdelay == true)//延迟点击两秒
      { if (Input.GetMouseButtonDown(0))
         {    if (lefttalkframe.activeSelf == true)
                  {if    (output[i].Contains("over"))//如果数组over了则使输入框出现
                           {
                            mask.SetActive(true);
                           }//对话框消失后输入框出现
                    else   {
                           q = output.Length;      //q为当前这句话的字数
                           namee.text = output[0];
                           text.DOText(output[i], q * 0.3f, true, ScrambleMode.Custom, " ");//字体出现时间为字数乘以0.3s
                           text.color = Color.red;
                           isdelay = false;
                           i++;
                           StartCoroutine("delay");
                           }
                  }
            else  {
                  lefttalkframe.SetActive(true);
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













