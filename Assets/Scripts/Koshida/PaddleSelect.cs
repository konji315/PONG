using UnityEngine;
using UnityEngine.UI;

public class PaddleSelect : MonoBehaviour {

    public GameObject[] _paddles1 = new GameObject[5];
    public GameObject[] _paddles2 = new GameObject[5];

    private int _paddle1_ID = 0;
    private int _paddle2_ID = 0;
    private int _paddle_num = 5;

    // Use this for initialization
    void Start () {
        _paddles1[_paddle1_ID].SetActive(true);
        _paddles2[_paddle2_ID].SetActive(true);
    }

    // Update is called once per frame
    void Update () {

        //Aキーを押したら
		if(Input.GetKeyDown(KeyCode.A))
        {
            //1Pの現在のパドルを非表示
            _paddles1[_paddle1_ID].SetActive(false);

            //次のパドルへ
            _paddle1_ID--;
            if(_paddle1_ID < 0)
            {
                _paddle1_ID = _paddle_num - 1;
            }

            //次のパドルを表示
            _paddles1[_paddle1_ID].SetActive(true);
        }
        //Dキーを押したら
        else if (Input.GetKeyDown(KeyCode.D))
        {
            //1Pの現在のパドルを非表示
            _paddles1[_paddle1_ID].SetActive(false);

            _paddle1_ID++;
            if (_paddle1_ID > _paddle_num - 1)
            {
                _paddle1_ID = 0;
            }
            //次のパドルを表示
            _paddles1[_paddle1_ID].SetActive(true);
        }

        //左矢印キーを押したら
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //2Pの現在のパドルを非表示
            _paddles2[_paddle2_ID].SetActive(false);

            _paddle2_ID--;
            if (_paddle2_ID < 0)
            {
                _paddle2_ID = _paddle_num - 1;
            }
            //次のパドルを表示
            _paddles2[_paddle2_ID].SetActive(true);
        }
        //右矢印キーを押したら
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //2Pの現在のパドルを非表示
            _paddles2[_paddle2_ID].SetActive(false);

            _paddle2_ID++;
            if (_paddle2_ID > _paddle_num - 1)
            {
                _paddle2_ID = 0;
            }
            //次のパドルを表示
            _paddles2[_paddle2_ID].SetActive(true);
        }
    }
}
