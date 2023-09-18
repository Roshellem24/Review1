using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    private void Update()
    {
        // Update the display score with the value from the GameManager. 
        scoreText.text = "Score" + GameManager.playerScore.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

}
