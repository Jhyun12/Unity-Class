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

    // �������� �浹�� ���� �� �����ϴ� �Լ��Դϴ�.
    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }

    // �������� �浹�� �ϰ� ���� �� �����ϴ� �Լ��Դϴ�.
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay");
    }

    // �������� �浹�� ����� �� �����ϴ� �Լ��Դϴ�.
    private void OnCollisionExit(Collision collision)
    {
        condition = false;
    }

    // OnTrigger : �������� �浹�� ���� �ʰ� �浹 ó���� �ϴ� �Լ��Դϴ�.

    // �������� �浹�� ���� �ʰ� �浹�� ���� �� �����ϴ� �Լ��Դϴ�.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("����");
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

