using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 5.1.2������ʾ
// ͨ��������������˶�
public class PlayerControl_5_6 : MonoBehaviour
{
    // Start is called before the first frame update
    public int velocityMultiple;
    private Rigidbody rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, 0, vertical).normalized; // Ϊ0����Ϊֻ����С��ƽ���ƶ�
        rbody.velocity = dir * velocityMultiple;
    }
}

// ����С���ƶ������������С����غ�ͨ�������������С����ƽ�����˶���velocityMultiple������С���ƶ��ٶȣ����ǲ��ܾ��������ٶ�