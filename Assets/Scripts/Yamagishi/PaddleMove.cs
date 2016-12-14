using UnityEngine;
using System.Collections;

public class PaddleMove : MonoBehaviour
{
    public float speed = 1.0f;

    void Update()
    {
        Vector3 move = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            move += new Vector3(1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            move += new Vector3(-1, 0, 0);
        }
        else
        {
            transform.position = transform.position;
        }

        transform.Translate(move * Time.deltaTime * speed);
        
    }
}
