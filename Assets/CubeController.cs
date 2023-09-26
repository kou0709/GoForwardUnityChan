using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    //�L���[�u�̈ړ����x
    private float speed = -12;

    //���ňʒu
    private float deadLine = -10;

    //�Ԃ��������̉�
    public AudioClip se;

    //�Đ��p
    AudioSource audiosource1;


    // Start is called before the first frame update
    void Start()
    {
        audiosource1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "UnityChan2DTag")
        {

        }
        else
        {
            audiosource1.PlayOneShot(se);
        }
    }
}
