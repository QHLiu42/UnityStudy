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
        // 从 Update 函数调用此函数，因为状态每帧都会重置。在用户释放鼠标按钮并再次按下之前，它不会返回 true。
        // 主按钮（通常是左按钮）的按钮值为 0，辅助按钮为 1，中间按钮为 2。
        if (Input.GetMouseButtonDown(0)) // 所以0表示左键
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if(Physics.Raycast(ray,out hit)) // C#语法 ref是传入值,out是传出值
            {
                if (hit.collider.tag == "Candle")
                {
                    if(hit.transform.GetChild(0).gameObject.activeSelf == true)
                    {
                        hit.transform.GetChild(0).gameObject.SetActive(false); // 让子物体火焰失活
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
