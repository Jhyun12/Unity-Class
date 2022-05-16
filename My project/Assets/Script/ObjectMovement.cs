using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public GameObject target;
    private float speed = 1.0f;

    private MeshRenderer render;

    private void Start()
    {
        render = GetComponent<MeshRenderer>();
    }



    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards
            (
            transform.position,
            target.transform.position,
            speed * Time.deltaTime
            );

        if(Input.GetKeyDown(KeyCode.Return))
        {
            Invoke("Paint", 3);
        }
       
    }

    

    public void Paint()
    {

        int value = Random.Range(0, 3);

        switch(value)
        {
            case 0:
                render.material.color = Color.green;
                break;
            case 1:
                render.material.color = Color.red;
                break; 
            case 2:
                render.material.color = Color.black;
                break;
        }

       
    }
}
