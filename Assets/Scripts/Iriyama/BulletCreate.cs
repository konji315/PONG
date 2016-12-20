using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreate : MonoBehaviour {

    public int frequency = 12;  //弾が生成される頻度

    [Tooltip("ギミック開始秒数")]
    public float start_time = 60;

    int count;              //カウント用
    
    public GameObject Bullet;   //生成するゲームオブジェクト

    // Use this for initialization
    void Start ()
    {
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (start_time < 0)
        {
            //弾を生成
            if (count >= frequency)
            {
                count = 0;
                Instantiate(Bullet, this.transform.position, Quaternion.identity);
            }
            count++;
        }
        start_time -= Time.deltaTime;
	}
}
