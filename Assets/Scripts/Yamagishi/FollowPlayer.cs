using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    public Transform target;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        //自分と相手の相対座標を求める
        offset = GetComponent<Transform>().position - target.position;

	}
	
	// Update is called once per frame
	void Update () {
        //自分の座標にtargetの座標を取得
        GetComponent<Transform>().position = target.position + offset;

	}
}
