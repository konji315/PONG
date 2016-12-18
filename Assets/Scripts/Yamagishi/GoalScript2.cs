using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript2 : MonoBehaviour
{
    private GameObject canvas;
    void Start()
    {
        canvas = GameObject.Find("CanvasPlayer2Win");
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
