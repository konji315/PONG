using UnityEngine;
using UnityEngine.UI;

public class PaddleSelect : MonoBehaviour {

    public Text text1;
    public Text text2;

    private int _paddle1_ID = 0;
    private int _paddle2_ID = 0;
    private int _paddle_num = 5;

    // Use this for initialization
    void Start () {
        text1.text = _paddle1_ID.ToString();
        text2.text = _paddle2_ID.ToString();
	}
	
	// Update is called once per frame
	void Update () {

        //Aキーを押したら
		if(Input.GetKeyDown(KeyCode.A))
        {
            _paddle1_ID--;
            if(_paddle1_ID < 0)
            {
                _paddle1_ID = _paddle_num;
            }

            text1.text = _paddle1_ID.ToString();
        }
        //Dキーを押したら
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _paddle1_ID++;
            if (_paddle1_ID > _paddle_num)
            {
                _paddle1_ID = 0;
            }
            text1.text = _paddle1_ID.ToString();
        }

        //左矢印キーを押したら
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _paddle2_ID--;
            if (_paddle2_ID < 0)
            {
                _paddle2_ID = _paddle_num;
            }

            text2.text = _paddle2_ID.ToString();
        }
        //右矢印キーを押したら
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _paddle2_ID++;
            if (_paddle2_ID > _paddle_num)
            {
                _paddle2_ID = 0;
            }

            text2.text = _paddle2_ID.ToString();
        }
    }
}
