using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorMowement : MonoBehaviour
{

    public float speed = 10f;
    private float direction;
    private bool mowe;
    public Transform shootPoint;
    public GameObject bullet;
    private float nextFire;
    public float fireRate = 2f;
    void Start()
    {
        shootPoint = transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (mowe == true)
        {
            if ((transform.position.x >= -17f) && (direction == 1f))
            {
                transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
            }

            if ((transform.position.x <= 25f) && (direction == -1f))
            {
                transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
            }
        }

        nextFire -= Time.deltaTime;
    }

    public void Left()
    {
        direction = 1;
        mowe = true;
    }

    public void Right()
    {
        direction = -1;
        mowe = true;
    }

    public void Stop()
    {
        mowe = false;
    }

    public void shoot()
    {
        print("вы выстрелили в бедную и нещасную овцу блоком сена :-( ");
        
        if(nextFire < 0)
        {
            Instantiate(bullet, shootPoint.position , bullet.transform.rotation);
            nextFire = fireRate;
        }
        
    }
}
