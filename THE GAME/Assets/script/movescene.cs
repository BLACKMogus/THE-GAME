using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class movescene : MonoBehaviour {

    public GameObject gate;
    public GameObject classroom;
    public GameObject canteen;
    public GameObject coffee;
    public GameObject basketball;
    public GameObject keysister;
    public GameObject afterbook;

    public GameObject afterclass;
    public GameObject afterdorm;
    public GameObject afterfootball;
    public GameObject lefttalk;

    void Start()
    {
        classroom.transform.Translate(new Vector2(gate.transform.position.x + Screen.width / 2, 0));
        canteen.transform.Translate(new Vector2(gate.transform.position.x + Screen.width / 2, 0));
        coffee.transform.Translate(new Vector2(gate.transform.position.x + Screen.width / 2, 0));
        basketball.transform.Translate(new Vector2(gate.transform.position.x + Screen.width / 2, 0));
        keysister.transform.Translate(new Vector2(gate.transform.position.x + Screen.width / 2, 0));

        afterbook.transform.Translate(new Vector2(gate.transform.position.x + Screen.width / 2, 0));
        afterclass.transform.Translate(new Vector2(gate.transform.position.x + Screen.width / 2, 0));
        afterdorm.transform.Translate(new Vector2(gate.transform.position.x + Screen.width / 2, 0));
        afterfootball.transform.Translate(new Vector2(gate.transform.position.x + Screen.width / 2, 0));
    }

    //stay
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
    * stay=20 晚修
    */

    //go
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
       * 
       * go=15  咖啡屋→钥匙妹
       * go=16 咖啡屋→食堂
    */
    void Update()
    {
        Debug.Log(talkframe.go);
    }

   public void ButtonNextScene(int n)
    {
        switch(talkframe.go)
        {
            case 2:
                MovePicture(gate, classroom, 2);break;
            case 3:
                MovePicture(classroom, canteen, 3);
                day1class.setfalse();break;
            case 4:
                MovePicture(classroom, coffee, 4);
                day1class.setfalse();break;
            case 5:
                MovePicture(canteen, basketball, 5);
                day1canteen.setfalse();break;
            case 6:
                MovePicture(basketball, afterdorm, 6);day1sport.SetFalse();
             break;
            case 7:
                MovePicture(basketball, canteen, 7); day1sport.SetFalse();
                break;
            case 8:
                MovePicture(basketball, afterfootball, 8); day1sport.SetFalse();
                break;
            case 9:
                MovePicture(basketball, afterbook, 9); day1sport.SetFalse();
                break;
            case 10:
                MovePicture(afterdorm, afterclass, 20);
               break;
            case 11:
                MovePicture(canteen, afterclass, 20);
                break;
            case 12:
                MovePicture(afterfootball, afterclass, 20);
                break;
            case 13:
                MovePicture(afterbook, afterclass, 20); break;
            case 15:
                MovePicture(coffee, keysister, 20); break;
            case 16:
                MovePicture(coffee, canteen, 3); day1canteen.withche = true;day2coffee.Setfalse(); break;
                    
            /*day2*/
            case 100:  reloadscene();break;










            default:break;
        }
    }
    void SetALLZero()
    {
        talkframe.i = 0;
        talkframe.havenext = true;
        talkframe.gonext =false;
        talkframe.go = 0;
        talkframe.stay = 0;
    }
    
    public void reloadscene()
    {
        playername.addone();
        SceneManager.LoadScene(1);
    }
    void MovePicture(GameObject nowobj,GameObject nextobj,int n)//现在场景，要去的场景，目的地状态
    {
        lefttalk.SetActive(false);
        nextobj.transform.DOLocalMoveX(0, 3);
        nowobj.transform.DOLocalMove(new Vector3(-Screen.width, 0, 0), 3);
        talkframe.stay = n;//状态为目的地
        talkframe.go = 0;//要到达的场景归零
        talkframe.gonext = false;//对话框消失
        talkframe.i = 1;//句子排序归零
        talkframe.havenext = true;
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
