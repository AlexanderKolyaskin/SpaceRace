using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : MonoBehaviour
{
    [SerializeField] Vector2 way;
    [SerializeField] float time;
    Rigidbody2D rbody;
    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        InvokeRepeating("MoveWay", 1, time);
    }

    void MoveWay()
    {
        rbody.velocity = way;
        way = new Vector2(way.x, -way.y);
    }
}
