using UnityEngine;
using UnityEngine.UI;

public class PaddleSelect : MonoBehaviour {

    public GameObject[] _paddles1 = new GameObject[5];
    public GameObject[] _paddles2 = new GameObject[5];

    public GameObject _UI_manager;

    [Range(0,4)]
    public int _paddle1_ID = 0;
    [Range(0, 4)]
    public int _paddle2_ID = 0;

    private int _paddle_num = 5;

    [System.NonSerialized]
    public bool _is_enter_1P;
    [System.NonSerialized]
    public bool _is_enter_2P;

    StatusUIScript statusUI;

    // Use this for initialization
    void Start () {
        PlayerPrefs.DeleteKey("paddle1");
        PlayerPrefs.DeleteKey("paddle2");

        _paddles1[_paddle1_ID].SetActive(true);
        _paddles2[_paddle2_ID].SetActive(true);
        statusUI = _UI_manager.GetComponent<StatusUIScript>();
        statusUI._1Pstatus_UI[_paddle1_ID].SetActive(true);
        statusUI._2Pstatus_UI[_paddle2_ID].SetActive(true);
    }

    // Update is called once per frame
    void Update () {

        if (!_is_enter_1P)
        {
            //Aキーを押したら
            if (Input.GetKeyDown(KeyCode.A))
            {
                //1Pの現在のパドルとステータスを非表示
                _paddles1[_paddle1_ID].SetActive(false);
                statusUI._1Pstatus_UI[_paddle1_ID].SetActive(false);

                //次のパドルへ
                _paddle1_ID--;
                if (_paddle1_ID < 0)
                {
                    _paddle1_ID = _paddle_num - 1;
                }

                //次のパドルとステータスを表示
                _paddles1[_paddle1_ID].SetActive(true);
                statusUI._1Pstatus_UI[_paddle1_ID].SetActive(true);
            }
            //Dキーを押したら
            else if (Input.GetKeyDown(KeyCode.D))
            {
                //1Pの現在のパドルとステータスを非表示
                _paddles1[_paddle1_ID].SetActive(false);
                statusUI._1Pstatus_UI[_paddle1_ID].SetActive(false);

                _paddle1_ID++;
                if (_paddle1_ID > _paddle_num - 1)
                {
                    _paddle1_ID = 0;
                }
                //次のパドルとステータスを表示
                _paddles1[_paddle1_ID].SetActive(true);
                statusUI._1Pstatus_UI[_paddle1_ID].SetActive(true);
            }
        }


        if (!_is_enter_2P)
        {
            //左矢印キーを押したら
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                //2Pの現在のパドルとステータスを非表示
                _paddles2[_paddle2_ID].SetActive(false);
                statusUI._2Pstatus_UI[_paddle2_ID].SetActive(false);

                _paddle2_ID--;
                if (_paddle2_ID < 0)
                {
                    _paddle2_ID = _paddle_num - 1;
                }
                //次のパドルとステータスを表示
                _paddles2[_paddle2_ID].SetActive(true);
                statusUI._2Pstatus_UI[_paddle2_ID].SetActive(true);
            }
            //右矢印キーを押したら
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                //2Pの現在のパドルとステータスを非表示
                _paddles2[_paddle2_ID].SetActive(false);
                statusUI._2Pstatus_UI[_paddle2_ID].SetActive(false);

                _paddle2_ID++;
                if (_paddle2_ID > _paddle_num - 1)
                {
                    _paddle2_ID = 0;
                }
                //次のパドルとステータスを表示
                _paddles2[_paddle2_ID].SetActive(true);
                statusUI._2Pstatus_UI[_paddle2_ID].SetActive(true);
            }
        }

        /////////////////////////////////////////////////////////////
        //パドル決定
        /////////////////////////////////////////////////////////////

        //1Pがパドル選択完了
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _is_enter_1P = true;
        }
        //1Pがパドル選択キャンセル
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _is_enter_1P = false;
        }


        //2Pがパドル選択完了
        if(Input.GetKeyDown(KeyCode.Return))
        {
            _is_enter_2P = true;
        }

        //2Pがパドル選択キャンセル
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            _is_enter_2P = false;
        }
    }
}
