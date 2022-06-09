using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject Prefab;
   
    public void PrefabCreate()
    {

        ObjectPool.objpool.GetQueue();
    }
}
