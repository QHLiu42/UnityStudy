using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl_3_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 dir =new  Vector3(horizontal, 0, vertical);

        if(dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }
    }
}

/*
 * 
 * 3.2 Ŀǰ�Ѿ�ʵ�ֵĹ��ܣ�����ǰ������ƽ��
 * Todo: 
 * 1. ʵ����������Ƕ��ƶ�
 * ʵ��������Ծ
 * ʵ�ֻ�����ײ
 */