using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour {

    private int count;
    public GameObject arrow;

	// Use this for initialization
	void Start ()
    {
        count = 0;
        arrow.SetActive(true);
	}
	
	// Update is called once per frame
	void Update ()
    {
        count++;
        if(count == 60)
        {
            arrow.SetActive(false);
        }
	}
}
