using UnityEngine;
using System.Collections;

public class PaddleMove2 : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        Vector3 move = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.A))
        {
            move += new Vector3(1, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            move += new Vector3(-1, 0, 0);
        }

        transform.Translate(move * Time.deltaTime * speed);
    }
}