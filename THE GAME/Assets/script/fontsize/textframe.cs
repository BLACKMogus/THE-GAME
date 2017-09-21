using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class textframe : MonoBehaviour {


    Text tex;
	// Use this for initialization
	void Start () {
        tex = this.gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        tex.fontSize = Screen.height / 24;
	}
}
