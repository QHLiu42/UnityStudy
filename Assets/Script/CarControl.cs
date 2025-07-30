using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    // Start is called before the first frame update
    public WheelCollider[] frontWheels; // ר�ŵĳ���������ײ��
    public WheelCollider[] backWheels;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        foreach (WheelCollider wheel in frontWheels)
        {
            wheel.steerAngle = horizontal * 30;
        }
        foreach (WheelCollider wheel in backWheels)
        {
            wheel.motorTorque = vertical * 30;
        }
        
    }
}

// ����ǰ���������Ŀ������������ֶ�ѡ���������ĸ�
