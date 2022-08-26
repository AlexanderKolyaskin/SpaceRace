using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedLfie : MonoBehaviour
{
    [SerializeField] float time;
    void Start()
    {
        Invoke("DestroyObj", time);
    }

    void DestroyObj()
    {
        Destroy(gameObject);
    }
}
    
