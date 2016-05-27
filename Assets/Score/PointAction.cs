using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointAction : MonoBehaviour {

    public  Text scoreText;
    public int score = 0;
    

    void Start()
    {
        scoreText.text = "Score: 0";
    }


     void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        if(other.gameObject)
        {
            score += 10;
            scoreText.text = "Score" + score.ToString();
        }
    }
}
