using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CountDown : MonoBehaviour {

    public Text _count_text;

    public int MAX_TIME = 4; // カウントダウンの開始値

    public GameObject _player_manager;

    float _time_counter;

    PaddleSelect ui;

    void Start()
    {
        _count_text.text = "";
        _time_counter = MAX_TIME;
        ui = _player_manager.GetComponent<PaddleSelect>();
    }

    void Update()
    {
        //両者決定を押したら
        if(ui._is_enter_1P&&ui._is_enter_2P)
        {
            //カウント開始
            if(_time_counter > 0.0f)
            {
                _time_counter -= Time.deltaTime;
            }
            else
            {
                PlayerPrefs.SetInt("paddle1", ui._paddle1_ID);
                PlayerPrefs.SetInt("paddle2", ui._paddle2_ID);

                SceneManager.LoadScene("PlayScene");
            }

            _count_text.text = ((int)_time_counter).ToString();
        }
        else
        {
            _time_counter = MAX_TIME;
            _count_text.text = "";
        }
    }
}
