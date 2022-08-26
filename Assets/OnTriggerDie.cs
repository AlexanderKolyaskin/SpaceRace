using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class OnTriggerDie : MonoBehaviour
{
    HPscript hps;
    [SerializeField] int points = 0;
    [SerializeField] UnityEvent PlayerTriggerEvent;
    [SerializeField] GameObject droppedPref;
    [SerializeField] UnityEvent EnemyCommonTriggerEvent;
    [SerializeField] UnityEvent EnemyUpdateTriggerEvent;
    [SerializeField] UnityEvent CommonBullBonus;
    [SerializeField] UnityEvent UpdateBullBonus;
    [SerializeField] UnityEvent ShieldBonus;
    public Text pointText;
    [SerializeField] bool IsNeedObj;


    private void Start()
    {
        if(IsNeedObj)
            pointText.text = points.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.CompareTag("Enemy") || collision.CompareTag("EnemyBullet")) && !gameObject.CompareTag("Enemy"))
        {
            PlayerTriggerEvent.Invoke();
            Instantiate(droppedPref, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);

        } else if(collision.CompareTag("CommonBullet") && gameObject.CompareTag("Enemy"))
        {
            EnemyCommonTriggerEvent.Invoke();
            Destroy(collision.gameObject);
            points += 25; 
            
        }
        else if (collision.CompareTag("UpdateBullet") && gameObject.CompareTag("Enemy"))
        {
            EnemyUpdateTriggerEvent.Invoke();
            Destroy(collision.gameObject);
            points += 50;
            
        } else if(collision.CompareTag("Common_Bull_Bonus") && gameObject.CompareTag("Player"))
        {
            CommonBullBonus.Invoke();
            Destroy(collision.gameObject);
        } else if( collision.CompareTag("Update_Bull_Bonus") && gameObject.CompareTag("Player"))
        {
            UpdateBullBonus.Invoke();
            Destroy(collision.gameObject);
        } else if(collision.CompareTag("Shield_Bonus") && gameObject.CompareTag("Player"))
        {
            ShieldBonus.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
