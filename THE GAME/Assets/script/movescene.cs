using UnityEngine;
using System.Collections;
using DG.Tweening;
public class movescene : MonoBehaviour {

    public GameObject gate;
    public GameObject classroom;
    public Transform path;
    public Transform coffee;
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
        //    gate.DOLocalMoveX();
            lefttalk.SetActive(false);
            classroom.transform.DOLocalMoveX(0, 3);
            gate.transform.DOLocalMove(new Vector3(-Screen.width,0,0),3);
            talkframe.stay = 2;
        }
    }
}
