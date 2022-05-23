using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControll : MonoBehaviour
{
    public int Health = 100;
    Rigidbody rigid;
    Vector3 dir;
    public float speed;
    bool condition;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

  
    void Update()
    {

        if(Health <= 0)
        {
            gameObject.SetActive(false);
        }

         dir.x = Input.GetAxis("Horizontal");
         dir.z = Input.GetAxis("vertical");

        if (Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            rigid.AddForce(new Vector3(0, 100, 0));
            condition = false;
        }

    }

    private void FixedUpdate()
    {
        rigid.MovePosition
            (
            rigid.position +
            dir *
            speed *
            Time.deltaTime
            );
    }

    // 물리적인 충돌을 했을 때 동작하는 함수입니다.
    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }

    // 물리적인 충돌을 하고 있을 때 동작하는 함수입니다.
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay");
    }

    // 물리적인 충돌을 벗어났을 때 동작하는 함수입니다.
    private void OnCollisionExit(Collision collision)
    {
        condition = false;
    }

    // OnTrigger : 물리적인 충돌을 하지 않고 충돌 처리를 하는 함수입니다.

    // 물리적인 충돌을 하지 않고 충돌을 했을 때 동작하는 함수입니다.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("감지");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("trigger Stay");
    }

    private void OnTriggerStay(Collision other)
    {
        Debug.Log("Trigger Exit");
    }
}

