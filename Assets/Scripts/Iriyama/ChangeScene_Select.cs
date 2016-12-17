using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//シーン移動のための名前領域
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChangeScene_Select : MonoBehaviour {

    public Image _panel;
    public float _fade_speed = 0.1f;

    private bool _is_push;

    float alpha;
    float red, green, blue;

	// Use this for initialization
	void Start () {
        _is_push = false;
        alpha = 0;
        red = _panel.GetComponent<Image>().color.r;
        green = _panel.GetComponent<Image>().color.g;
        blue = _panel.GetComponent<Image>().color.b;
    }

    // Update is called once per frame
    void Update () {
        //何かのキーが押されたら
        if (Input.anyKey)
        {
            _is_push = true;

        }

        //フェードアウト開始
        if(_is_push)
        {
            _panel.GetComponent<Image>().color = new Color(red, green, blue, alpha);
            alpha += _fade_speed;
        }
        else
        {
            alpha = 0;
        }

        if(alpha > 1.0f)
        {
            //シーン移動
            SceneManager.LoadScene("PaddleSelectScene");
        }
    }
}
