using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] private GameObject player;

    void FixedUpdate()
    {
moving();
    }

    private void moving()
    {
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += Vector3.right *5f* Time.deltaTime;
            player.GetComponent<Animator>().SetInteger("GoTomove",1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += Vector3.left *5f* Time.deltaTime;
            player.GetComponent<Animator>().SetInteger("GoTomove",1);
        }
        else
        {
            player.GetComponent<Animator>().SetInteger("GoTomove",0);
        }
    }
}

