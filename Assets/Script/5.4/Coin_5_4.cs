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
        //    other.GetComponent<Playcontrol_5_4>().AddCoin(); // �ᶨλ����ײ���ҳ�����ײ�е��Ǹ�������   
        //    Destroy(gameObject); // ����Ҳ�ܳԶ���ֻ�������б���
        //}

        if (other.CompareTag("Player"))
        {
            // var playerControl = other.GetComponentInParent<Playcontrol_5_4>(); // �����и�������Ѱ��
            var playerControl = other.GetComponent<Playcontrol_5_4>();
            if (playerControl != null)
            {
                playerControl.AddCoin();
                Debug.Log(gameObject.name + " �ҵ��� Playcontrol_5_4 ���" + other.name);
                Destroy(gameObject);
            }
            else
            {
                Debug.Log(gameObject.name + " û���ҵ� Playcontrol_5_4 ���" + other.name); // �ᱻ��������Ϊͬʱ��������ײ�з�������ײ
            }
        }

    }

    // ���ղ㼶���Һ����Ķ���
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
    // ʹ�÷���
    // ����ֻ����2�㸸����
    //var playerControl = GetComponentInParentWithLevel<Playcontrol_5_4>(other.transform, 2);
    //if (playerControl != null)
    //{
    //    playerControl.AddCoin();
    //}
}
