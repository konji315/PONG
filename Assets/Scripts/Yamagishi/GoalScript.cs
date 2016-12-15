using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {

    //トリガーとの接触時に呼び出されるコールバック
    void OnTriggerEnter(Collider hit)
    {
        //接触対象はプレイヤータグですか？
        if (hit.tag == ("Ball"))
        {
            
        }
    }
}
