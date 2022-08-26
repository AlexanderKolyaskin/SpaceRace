using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject EnemyShip1, EnemyShip2, EnemyShip3, EnemyShip4;
    [SerializeField] float z;
    [SerializeField] int Rmax, Rmin;
    [SerializeField] float TimeRepeat;
    void Start()
    {
        InvokeRepeating("spawner", 3, TimeRepeat);
    }

    void spawner()
    {
        int temp_spawn = Random.Range(1, 4);
        Vector3 Rpos = new Vector3(transform.position.x, Random.Range(Rmin, Rmax), z);
        if(temp_spawn == 1)
        {
            Instantiate(EnemyShip1, Rpos, transform.rotation);
        }else if (temp_spawn == 2)
        {
            Instantiate(EnemyShip2, Rpos, transform.rotation);
        }else if (temp_spawn == 3)
        {
            Instantiate(EnemyShip3, Rpos, transform.rotation);
        }
        else if (temp_spawn == 4)
        {
            Instantiate(EnemyShip4, Rpos, transform.rotation);
        }
    }
}
