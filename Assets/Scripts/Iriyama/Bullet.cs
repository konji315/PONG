using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float shotSpeed = 10.0f;     //速度
    //private float shotDirection = 180; //角度
    private float shotDirection; //角度
    private float shotDirection2; //角度(上方向から見たやつ)
    public float destroyTime = 300.0f;     //生成されたオブジェクトが消えるまでの時間
    private float destroyNowTime = 0;       //経過したフレーム

    public float rotateSpeedX = 0.05f;    //X回転速度
    public float rotateSpeedY = 0.05f;    //Y回転速度
    public float rotateSpeedZ = 0.05f;    //Z回転速度
    //float rotateNowSpeed = rotateSpeed;

    // Use this for initialization
    void Start () {
        shotDirection = Random.Range(0, 360);
        shotDirection2 = Random.Range(0, 360);

        Vector3 v;
        //指定した方向に設定
        v.x = Mathf.Cos(Mathf.Deg2Rad * shotDirection) * shotSpeed;
        v.y = Mathf.Sin(Mathf.Deg2Rad * shotDirection) * 0;
        v.z = Mathf.Sin(Mathf.Deg2Rad * shotDirection2) * shotSpeed;
        //Rigidbody型rdを作成
        Rigidbody rd = GetComponent<Rigidbody>();
        //指定した方向に進める
        rd.velocity = v;
    }
	
	// Update is called once per frame
	void Update () {
        if(destroyNowTime >= destroyTime)
        {
            Destroy(this.gameObject);
        }
        destroyNowTime++;

        //Rigidbody型rdを作成
        Rigidbody rd = GetComponent<Rigidbody>();
        //指定した速度で回転をする
        rd.angularVelocity = new Vector3(rotateSpeedX, rotateSpeedY, rotateSpeedZ);
    }
}
