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
 * 3.2 目前已经实现的功能：人物前后左右平移
 * Todo: 
 * 1. 实现人物各个角度移动
 * 实现人物跳跃
 * 实现环境碰撞
 */