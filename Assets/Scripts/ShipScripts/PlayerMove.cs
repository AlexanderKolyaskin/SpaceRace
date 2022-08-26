using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 5;
    Rigidbody2D rbody2D;
    [SerializeField] UnityEvent PauseOn;
    [SerializeField] UnityEvent PauseOff;
    [SerializeField] bool IsPasue = false;

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody2D.velocity = new Vector2(
            Input.GetAxis("Horizontal") * speed,
            Input.GetAxis("Vertical") * speed
        );

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPasue == false) {
                PauseOn.Invoke();
                IsPasue = true;
            } else if (IsPasue == true){
                PauseOff.Invoke();
                IsPasue = false;
            }

        }
    }
}
