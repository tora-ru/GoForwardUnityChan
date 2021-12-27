using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public AudioClip sound;
    //�L���[�u�̈ړ����x
    private float speed = -12;

    //���ňʒu
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
        //�L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
        //bool isCube = (transform.position.y = this.oneCube) ? false : true;
        //GetComponent<AudioSource>().volume = (transform.position.y = oneCube)
    }

    //�Փˎ��ɉ���炷
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
 