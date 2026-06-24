
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KillEnemy : MonoBehaviour
{
    
    private Text scoreinfo;
    private static int score;


    private void Start()
    {   Load();
        scoreinfo = GameObject.Find("scoreinfi").GetComponent<Text>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bullet"))
        {
            GameObject.Find("Boom").GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            score++;
            scoreinfo.text = "Score: " + score;
            Save();
        }
    }

    private void Save()
    {
        PlayerPrefs.SetInt("score", score);
    }

    private void Load()
    {
        score=PlayerPrefs.GetInt("score");
    }
}
