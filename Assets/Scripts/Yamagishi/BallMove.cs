using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour
{
    public float speed = 1;
    private int count = 0;

	// Use this for initialization
	void Start ()
    {
    }

    // Update is called once per frame
    void Update ()
    {
        count++;
        if (count == 60)
        {
            this.GetComponent<Rigidbody>().AddForce(
                (transform.forward + transform.right) * speed,
                ForceMode.VelocityChange);
        }
    }
}
