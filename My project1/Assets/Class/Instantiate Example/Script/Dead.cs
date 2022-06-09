using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }


    private void OnBecameInvisible()
    {
        rigid.velocity = Vector3.zero;
        gameObject.transform.position = new Vector3(0,5,0);
        ObjectPool.objpool.InsertQueue(gameObject);
    }
}
