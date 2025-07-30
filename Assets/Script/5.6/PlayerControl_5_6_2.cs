using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
public class PlayerControl_5_6_2 : MonoBehaviour // PlayerControl_5_6与unity 命名空间中变量重名
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0) // 左右
        {
            transform.position -= Vector3.left * 10f * Time.deltaTime * horizontal;
            if (transform.position.x < -10f || transform.position.x > 10f)
            {
                transform.position += Vector3.left * 10f * Time.deltaTime * horizontal;
            }
        }

        float vertical = Input.GetAxis("Vertical");
        if (vertical != 0) // 上下
        {
            transform.position += Vector3.up * 10f * Time.deltaTime * vertical;
            if (transform.position.y < -10f || transform.position.y > 10f)
            {
                transform.position -= Vector3.up * 10f * Time.deltaTime * vertical;
            }
        }
    }

    // 当此碰撞器/刚体开始接触另一个刚体/碰撞器时，调用 OnCollisionEnter
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("游戏结束 OnCollisionEnter: " + collision.gameObject.name);
        Time.timeScale = 0f; // 停止游戏
    }
}
