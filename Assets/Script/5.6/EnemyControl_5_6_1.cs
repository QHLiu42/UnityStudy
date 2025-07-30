using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl_5_6_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.forward * 100f * Time.deltaTime;
        if(transform.position.z < -20f)
        {
            Destroy(gameObject); 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}

