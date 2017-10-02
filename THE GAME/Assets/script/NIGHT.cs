using UnityEngine;
using System.Collections;

public class NIGHT : MonoBehaviour {

    int nexttalk;
    void Start () {
        nexttalk = 0;
	}
	
	// Update is called once per frame
	void Update () {
	if(talkframe.stay==(20))
        {
            if(talkframe.havenext==true)
            {
                NightTalk(nexttalk);
            }
        }
	}


    void NightTalk(int i)
    {
        string[] zero = { "老师", "有人出事故了", "222", "next" };
        string[] one = { "", "心理活动", "", "next" };
        string[] two = { "", "", "", "" };
        string[] three = { "", "", "", "" };
        string[] four = { "", "", "", "" };
        string[] five = { "", "", "", "" };
        string[] six = { "", "", "", "" };
        switch (i)
        {
            case 0:talkframe.output = zero;stopchoose(); break;
            case 1: talkframe.output = one; stopchoose(); talkframe.go = 100; talkframe.gonext = true; break;
            case 2: talkframe.output = two; stopchoose(); break;
            case 3: talkframe.output = three; stopchoose(); break;
            case 4: talkframe.output = four; stopchoose(); break;
            case 5: talkframe.output = five; stopchoose(); break;
            case 6: talkframe.output = six; stopchoose(); break;
            default:break;

        }
    }
    void stopchoose()
    {
        talkframe.i = 1;
        nexttalk++;
        talkframe.havenext = false;
    }

}
