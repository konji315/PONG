using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreate : MonoBehaviour {

    public int frequency = 12;  //弾が生成される頻度
    int count = 0;              //カウント用

    public GameObject Bullet;   //生成するゲームオブジェクト

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //弾を生成
        if(count >= frequency)
        {
            count = 0;
            Instantiate(Bullet);
        }
        count++;
	}
}
