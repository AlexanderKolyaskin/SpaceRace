using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReset : MonoBehaviour
{
    [SerializeField] float Xlmit = 0;
    void FixedUpdate()
    {
        if(transform.position.x > -Xlmit && transform.position.x < Xlmit)
        {

        }else
        {
            Destroy(gameObject);
        }
    }
}
