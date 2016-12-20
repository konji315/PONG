using UnityEngine;
using System.Collections;
using DG.Tweening;

public class PaddleMove : MonoBehaviour
{
    public AudioClip _paralysis_se;
    public float speed = 1.0f;

    private float _invincible_time = 0;

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

        transform.Translate(move * Time.deltaTime * speed);

        //無敵時間の減少
        if (_invincible_time >= 0.0f)
        {
            _invincible_time -= Time.deltaTime;
        }
    }

    //バレットに当たったら
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            //無敵じゃなかったら
            if (_invincible_time < 0.0f)
            {
                _invincible_time = 1.0f;
                GetComponent<AudioSource>().PlayOneShot(_paralysis_se);
                transform.DOShakePosition(1.0f);
            }
        }
    }
}