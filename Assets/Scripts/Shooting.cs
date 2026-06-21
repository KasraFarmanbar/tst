using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject shootingpalce;

    private void Update()
    {
        Shoot();
    }

    private void HowToShoot()
    {
     GameObject b= Instantiate(bullet, shootingpalce.transform.position, Quaternion.identity);
     b.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 1000);
        Destroy(b,6f);
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
           HowToShoot();
        }
    }
    
}