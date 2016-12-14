using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour
{
    public float speed = 1;

	// Use this for initialization
	void Start ()
    {
        this.GetComponent<Rigidbody>().AddForce(
    (transform.forward + transform.right) * speed,
    ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update ()
    {

    }
}
