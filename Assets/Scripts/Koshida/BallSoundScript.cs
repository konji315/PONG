using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSoundScript : MonoBehaviour {

    public AudioClip _paddle_se;
    public AudioClip _wall_se;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //衝突判定
    void OnCollisionEnter(Collision collision)
    {
        //パドルと衝突したとき
        if(collision.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(_paddle_se);
        }

        if(collision.gameObject.tag =="Wall")
        {
            GetComponent<AudioSource>().PlayOneShot(_wall_se);
        }
    }
}
