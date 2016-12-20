using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//シーン移動するための名前領域
using UnityEngine.SceneManagement;

public class GoalScript1 : MonoBehaviour
{
    public GameObject canvas;
    private bool goal;

    void Start()
    {
        canvas.SetActive(false);
        goal = false;
    }

    //トリガーとの接触時に呼び出されるコールバック
    void OnTriggerEnter(Collider hit)
    {
        //接触対象はプレイヤータグですか？
        if (hit.tag == ("Ball"))
        {
            canvas.SetActive(true);
            goal = true;
        }
    }

    void Update()
    {
        //ゴールした後かどうか
        if(goal == true)
        {
            //エンターかスペースでパドル選択シーンに移動
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("PaddleSelectScene");
            }
        }
    }
}
