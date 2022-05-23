using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllor : MonoBehaviour
{
    public float speed;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("vertical");

        Vector3 dir = new Vector3(x, 0, z);

        transform.Translate(dir.normalized *
            speed *
            Time.deltaTime
            );

    }

       
    
}
