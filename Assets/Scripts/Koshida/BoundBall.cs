using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundBall : MonoBehaviour {

    public float _power = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            collision.rigidbody.velocity = collision.rigidbody.velocity.normalized * _power;
        }
    }
}
