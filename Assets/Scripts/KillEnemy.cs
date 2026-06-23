
using UnityEngine;
using UnityEngine.UI;

public class KillEnemy : MonoBehaviour
{
   

    private Text scoreinfo;
    private static int score;

    private void Start()
    {
        scoreinfo = GameObject.Find("scoreinfi").GetComponent<Text>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bullet"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            score++;
            scoreinfo.text = "Score: " + score;
        }
    }
}
