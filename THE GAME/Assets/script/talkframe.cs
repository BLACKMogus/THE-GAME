using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;
public class talkframe : MonoBehaviour {
    int i = 0;
    public GameObject mask;
    public Text input;
	public enum state
    {
        gate,
        classroom,
        canteen,
        playground,

    }
    public Text lefttext;
    public Text righttext;
    public static state map;
    string[] morning = { "啊~~早啊...", "怎么还不去课室","over" };
    string[] noon = { "你没睡醒吧...现在是早上啊","over"};
    string[] evening = { "你没睡醒吧...现在是晚上啊" ,"over"};
    string[] output;









	void Start () {
        map = state.gate;
        output = morning;
	}
	
	// Update is called once per frame
	void Update () {
        talk();
	}


    public void talk()
    {
        if (map == state.gate)
        {
            if (Input.GetMouseButtonDown(0))
           {
                if (output[i].Contains("over"))
                {
                    mask.SetActive(true);
                }
                else
                {
                    lefttext.DOText(output[i], 2f, true, ScrambleMode.Custom, " ");
                    i++;
                }
                
            }
        }

    }
    public void dispeararrow()
    {
        mask.SetActive(false);
    }

    public void morningbutton()
    {
       if(input.text.Contains("午"))
        {
            i = 0;
          
            output = noon;
        }
       if(input.text.Contains("晚"))
        {
            i = 0;
            output = evening;
        }
    }












}
