using UnityEngine;
using System.Collections;
using DG.Tweening;
public class movescene : MonoBehaviour {

    public GameObject gate;
    public GameObject classroom;
    //public Transform path;
    //public Transform coffee;
    public GameObject lefttalk;

    void Start () {
        classroom.transform.Translate(new Vector2(gate.transform.position.x+Screen.width/2,0));
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    public void ButtonNextScene()
    {
       
        if(talkframe.go==2)
        {
            MovePicture(gate, classroom,2);
        }
    }

    void MovePicture(GameObject nowobj,GameObject nextobj,int n)//现在场景，要去的场景，目的地状态
    {
        lefttalk.SetActive(false);
        nextobj.transform.DOLocalMoveX(0, 3);
        nowobj.transform.DOLocalMove(new Vector3(-Screen.width, 0, 0), 3);
        talkframe.stay = n;//状态为目的地
        talkframe.go = 0;//要到达的场景归零
        talkframe.i = 1;//句子排序归零
        talkframe.isdelay = false;//点击关闭
        talkframe.stopcoroutine = true;//关闭主程序协程
        StartCoroutine("delay3s");
    }
    IEnumerator delay3s()
    {
       
        yield return new WaitForSeconds(3f);
        talkframe.isdelay = true;
        talkframe.stopcoroutine = false;
    }
}
