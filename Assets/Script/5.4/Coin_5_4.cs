using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_5_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Player") // 
        //{
        //    other.GetComponent<Playcontrol_5_4>().AddCoin(); // 会定位到碰撞并且持有碰撞盒的那个子物体   
        //    Destroy(gameObject); // 这样也能吃豆，只不过会有报错
        //}

        if (other.CompareTag("Player"))
        {
            // var playerControl = other.GetComponentInParent<Playcontrol_5_4>(); // 在所有父物体中寻找
            var playerControl = other.GetComponent<Playcontrol_5_4>();
            if (playerControl != null)
            {
                playerControl.AddCoin();
                Debug.Log(gameObject.name + " 找到了 Playcontrol_5_4 组件" + other.name);
                Destroy(gameObject);
            }
            else
            {
                Debug.Log(gameObject.name + " 没有找到 Playcontrol_5_4 组件" + other.name); // 会被触发，因为同时有两个碰撞盒发生了碰撞
            }
        }

    }

    // 按照层级查找函数的定义
    public static T GetComponentInParentWithLevel<T>(Transform start, int maxLevel) where T : Component
    {
        Transform current = start;
        int level = 0;
        while (current != null && level <= maxLevel)
        {
            T comp = current.GetComponent<T>();
            if (comp != null)
                return comp;
            current = current.parent;
            level++;
        }
        return null;
    }
    // 使用方法
    // 例如只查找2层父物体
    //var playerControl = GetComponentInParentWithLevel<Playcontrol_5_4>(other.transform, 2);
    //if (playerControl != null)
    //{
    //    playerControl.AddCoin();
    //}
}
