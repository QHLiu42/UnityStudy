using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CandleControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �� Update �������ô˺�������Ϊ״̬ÿ֡�������á����û��ͷ���갴ť���ٴΰ���֮ǰ�������᷵�� true��
        // ����ť��ͨ������ť���İ�ťֵΪ 0��������ťΪ 1���м䰴ťΪ 2��
        if (Input.GetMouseButtonDown(0)) // ����0��ʾ���
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if(Physics.Raycast(ray,out hit)) // C#�﷨ ref�Ǵ���ֵ,out�Ǵ���ֵ
            {
                if (hit.collider.tag == "Candle")
                {
                    if(hit.transform.GetChild(0).gameObject.activeSelf == true)
                    {
                        hit.transform.GetChild(0).gameObject.SetActive(false); // �����������ʧ��
                    }
                    else
                    {
                        hit.transform.GetChild(0).gameObject.SetActive(true);
                    }
                }
            }
        }
    }
}
