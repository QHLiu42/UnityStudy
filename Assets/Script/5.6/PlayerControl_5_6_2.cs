using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
public class PlayerControl_5_6_2 : MonoBehaviour // PlayerControl_5_6��unity �����ռ��б�������
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0) // ����
        {
            transform.position -= Vector3.left * 10f * Time.deltaTime * horizontal;
            if (transform.position.x < -10f || transform.position.x > 10f)
            {
                transform.position += Vector3.left * 10f * Time.deltaTime * horizontal;
            }
        }

        float vertical = Input.GetAxis("Vertical");
        if (vertical != 0) // ����
        {
            transform.position += Vector3.up * 10f * Time.deltaTime * vertical;
            if (transform.position.y < -10f || transform.position.y > 10f)
            {
                transform.position -= Vector3.up * 10f * Time.deltaTime * vertical;
            }
        }
    }

    // ������ײ��/���忪ʼ�Ӵ���һ������/��ײ��ʱ������ OnCollisionEnter
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("��Ϸ���� OnCollisionEnter: " + collision.gameObject.name);
        Time.timeScale = 0f; // ֹͣ��Ϸ
    }
}
