using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceReset : MonoBehaviour
{
    [SerializeField] GameObject gm;

    void Update()
    {
        if(transform.position.x < -19.18f)
        {
            transform.position = new Vector2(gm.transform.position.x + 22.36064f, 0);
        }
    }
}
