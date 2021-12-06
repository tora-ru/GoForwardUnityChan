using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public AudioClip sound;
    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    private AudioSource se;

    private bool isSound;

    // Start is called before the first frame update
    void Start()
    {
        this.se = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
        //bool isCube = (transform.position.y = this.oneCube) ? false : true;
        //GetComponent<AudioSource>().volume = (transform.position.y = oneCube)
    }

    //衝突時に音を鳴らす
    void OnCollisionEnter2D(Collision2D collision)
    {
        var cube = transform.position;
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "cube")
        {
            if (isSound == false)
            {
                this.se.PlayOneShot(this.sound);
                isSound = true;
            }
            //this.se.PlayOneShot(this.sound);
            //this.se.volume = (cube.y = -0.3316077) ? 1 : 0;
        }
    }
}
 