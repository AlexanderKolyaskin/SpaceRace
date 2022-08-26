using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPscript : MonoBehaviour
{
    [SerializeField] int HPpoint;
    [SerializeField] GameObject droppedPref;
    [SerializeField] int ArmorPoint;
    [SerializeField] bool IsNeedObjects;
    public Text ShieldText;
    public void ChangePoint(int Damage)
    {
        if(ArmorPoint > 0)
        {
            ArmorPoint--;
            if(IsNeedObjects)
                ShieldText.text = ArmorPoint.ToString();
        } else if(ArmorPoint <= 0)
        {
            HPpoint-= Damage;
        }
    }

    private void Start()

    {
        if(IsNeedObjects)
            ShieldText.text = ArmorPoint.ToString();
    }

    private void FixedUpdate()
    {
        if(HPpoint <= 0)
        {
            Instantiate(droppedPref, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    public void ChangeCountShield(int value)
    {
        ArmorPoint += value;
        ShieldText.text = ArmorPoint.ToString();
    }
}
