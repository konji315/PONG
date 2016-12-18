using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusUIScript : MonoBehaviour {
    public GameObject[] _1Pstatus_UI = new GameObject[5];
    public GameObject[] _2Pstatus_UI = new GameObject[5];

    public GameObject _player_manager;

    public GameObject _1P_ready;
    public GameObject _2P_ready;

    PaddleSelect paddle_select;

	// Use this for initialization
	void Start () {
        _1P_ready.SetActive(false);
        _2P_ready.SetActive(false);
        paddle_select = _player_manager.GetComponent<PaddleSelect>();
	}
	
	// Update is called once per frame
	void Update () {
        if(paddle_select._is_enter_1P)
        {
            _1P_ready.SetActive(true);
        }
        else
        {
            _1P_ready.SetActive(false);
        }


        if (paddle_select._is_enter_2P)
        {
            _2P_ready.SetActive(true);
        }
        else
        {
            _2P_ready.SetActive(false);
        }
    }
}
