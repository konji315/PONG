using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CountDown : MonoBehaviour {

    public Text _count_text;

    public int MAX_TIME = 4; // カウントダウンの開始値

    public GameObject _player_manager;

    public Image _panel;

    public float _fade_speed = 0.01f;

    float time_counter;
    float alpha;
    float red, green, blue;

    PaddleSelect ui;

    void Start()
    {
        alpha = 0;
        red = _panel.GetComponent<Image>().color.r;
        green = _panel.GetComponent<Image>().color.g;
        blue = _panel.GetComponent<Image>().color.b;

        _count_text.text = "";
        time_counter = MAX_TIME;
        ui = _player_manager.GetComponent<PaddleSelect>();
    }

    void Update()
    {
        //両者決定を押したら
        if(ui._is_enter_1P&&ui._is_enter_2P)
        {
            //カウント開始
            if(time_counter > 0.0f)
            {
                time_counter -= Time.deltaTime;
            }
            else
            {
                PlayerPrefs.SetInt("paddle1", ui._paddle1_ID);
                PlayerPrefs.SetInt("paddle2", ui._paddle2_ID);

                alpha += _fade_speed;

            }

            _count_text.text = ((int)time_counter).ToString();
        }
        else
        {
            alpha = 0;
            time_counter = MAX_TIME;
            _count_text.text = "";
        }

        _panel.GetComponent<Image>().color = new Color(red, green, blue, alpha);

        if (alpha > 1.0f)
        {
            SceneManager.LoadScene("PlayScene");
        }
    }
}
