using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 5.1.2操作演示
// 通过刚体控制球体运动
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
        Vector3 dir = new Vector3(horizontal, 0, vertical).normalized; // 为0是因为只想让小球平面移动
        rbody.velocity = dir * velocityMultiple;
    }
}

// 控制小球移动，具体表现是小球落地后，通过方向键，控制小球在平面上运动，velocityMultiple决定了小球移动速度，但是不能决定下落速度