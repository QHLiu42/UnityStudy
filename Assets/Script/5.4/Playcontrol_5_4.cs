using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playcontrol_5_4 : MonoBehaviour
{
    private Rigidbody rbody;
    private int CoinCount;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);
            rbody.velocity = 3 * dir.normalized;
        }
        else
        {
            rbody.velocity = Vector3.zero;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Enemy") // 这里一直进来可能是地板tag不对  unity碰到球的时候有报错
        {
            Debug.Log("Game ending");
            Time.timeScale = 0;
        }
    }
    public void AddCoin()
    {
        CoinCount++;
        if (CoinCount >= 5)
        {
            Debug.Log("Game ending");
            Time.timeScale = 0;
        }
    }
}
