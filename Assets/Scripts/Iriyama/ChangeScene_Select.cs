using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//シーン移動のための名前領域
using UnityEngine.SceneManagement;

public class ChangeScene_Select : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //何かのキーが押されたら
        if (Input.anyKey)
        {
            //シーン移動
            SceneManager.LoadScene("PaddleSelectScene");

        }
    }
}
