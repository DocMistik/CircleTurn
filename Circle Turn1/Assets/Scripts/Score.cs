using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public int score;
    [SerializeField] Text scoreText;
    [SerializeField] Text highscoreText;
    private int maxscore = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus")
        {
            Destroy(other.gameObject);
            score++;
            scoreText.text = "Score: " + score.ToString();
            if (score > maxscore)
            {
                maxscore = score;
                highscoreText.text = "Highscore: " + maxscore.ToString();
            }
        }
        if (other.gameObject.tag == "Enemy")
        {
            scoreText.text = scoreText.text = "Score: 0";
            score = 0;
        }
    }

    private void Update()
    {
        
    }

}
