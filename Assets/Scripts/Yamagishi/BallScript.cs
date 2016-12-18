using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour
{
    public float speed = 1;
    private int count = 0;
    private GameObject canvas;

	// Use this for initialization
	void Start ()
    {
        canvas = GameObject.Find("CanvasGameStart");
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
            canvas.SetActive(false);
        }
    }
}
