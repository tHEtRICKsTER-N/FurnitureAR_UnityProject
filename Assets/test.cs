using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;

    public void change()
    {
        Transform tempTransform = obj.transform;
        Destroy(obj.gameObject);

        obj = Instantiate(obj2,tempTransform.position,tempTransform.rotation);
    }
}
