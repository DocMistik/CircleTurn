using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public int score;
    [SerializeField] Text scoreText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus")
        {
            Destroy(other.gameObject);
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        
    }

}
