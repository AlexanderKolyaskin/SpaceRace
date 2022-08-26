using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMoveControl : MonoBehaviour
{
    void FixedUpdate()
    {
        if(transform.position.y > 4.60f)
        {
            transform.position = new Vector3(transform.position.x, 4.60f, -9);
        } if (transform.position.y < -4.60f)
        {
            transform.position = new Vector3(transform.position.x, -4.60f, -9);
        } if (transform.position.x > 7.14f)
        {
            transform.position = new Vector3(7.14f, transform.position.y, -9);
        }
        if (transform.position.x < -7.14f)
        {
            transform.position = new Vector3(-7.14f, transform.position.y, -9);
        }
    }
}
