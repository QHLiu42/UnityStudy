using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Animation ani;
    private bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0�������
        {
            if (ani.isPlaying == false && isOpen == false)
            {
                ani.Play("Open");
                isOpen = true;
            }
        }
        if (Input.GetMouseButtonDown(0)) // 1�����Ҽ�
        {
            if (ani.isPlaying == false && isOpen == true)
            {
                ani.Play("Close");
                isOpen = false;
            }
        }
    }
}
