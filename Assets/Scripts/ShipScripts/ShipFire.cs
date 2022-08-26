using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipFire : MonoBehaviour
{
    [SerializeField] GameObject NowBullet;
    [SerializeField] GameObject CommonBullet, SuperBullet;
    [SerializeField] int BulletCount = 10;
    [SerializeField] int UpBulletCount = 0;
    public Text CommonBulletText;
    public Text UpBulletText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(NowBullet == CommonBullet && BulletCount > 0)
            {
                Instantiate(CommonBullet, transform.position, transform.rotation);
                BulletCount--;
                CommonBulletText.text = BulletCount.ToString();
            } else if(NowBullet == SuperBullet && UpBulletCount > 0)
            {
                Instantiate(SuperBullet, transform.position, transform.rotation);
                UpBulletCount--;
                UpBulletText.text = UpBulletCount.ToString();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            NowBullet = CommonBullet;
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            NowBullet = SuperBullet;
        }
    }

    private void Start()
    {
        CommonBulletText.text = BulletCount.ToString();
        UpBulletText.text = UpBulletCount.ToString();
    }

    public void ChangeCountCommonBullet(int value)
    {
        BulletCount += value;
        CommonBulletText.text = BulletCount.ToString();
    }

    public void ChangeCountUpdateBullet(int value)
    {
        UpBulletCount += value;
        UpBulletText.text = UpBulletCount.ToString();
    }

}
