using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutPaddle : MonoBehaviour {

    public GameObject[] _paddles1 = new GameObject[5];
    public GameObject[] _paddles2 = new GameObject[5];

    // Use this for initialization
    void Start () {
        _paddles1[PlayerPrefs.GetInt("paddle1", 0)].SetActive(true);

        _paddles2[PlayerPrefs.GetInt("paddle2", 0)].SetActive(true);

        PlayerPrefs.DeleteKey("paddle1");
        PlayerPrefs.DeleteKey("paddle2");
    }
}
