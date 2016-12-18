using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript1 : MonoBehaviour
{
    private GameObject canvas;


    void Start()
    {
        canvas = GameObject.Find("CanvasPlayer1Win");
        canvas.SetActive(false);
    }

    //トリガーとの接触時に呼び出されるコールバック
    void OnTriggerEnter(Collider hit)
    {
        //接触対象はプレイヤータグですか？
        if (hit.tag == ("Ball"))
        {
            canvas.SetActive(true);
        }
    }
}
