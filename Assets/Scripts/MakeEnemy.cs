using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MakeEnemy : MonoBehaviour
{
  [SerializeField] private GameObject enemy;
  private float timer;
  private void FixedUpdate()
  {
    Timer();
  }

  private void Makeenemy()
  {
    Instantiate(enemy, new Vector3(Random.Range(-7.24f, 8.41f),6,0),Quaternion.identity);
  }

  private void Timer()
  {
    timer+= 1* Time.deltaTime;
    if (timer > 3f)
    {
      timer = 0;
      Makeenemy();
    }
  }
}
