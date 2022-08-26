using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMove : MonoBehaviour
{
    Rigidbody2D rbody2D;
    [SerializeField] Vector2 velocity;

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        rbody2D.velocity = this.velocity;
    }
}
