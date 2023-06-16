using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreL3 : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        int score = Mathf.FloorToInt(player.position.z);

        if (score >= 300)
        {
            score = 300;
            enabled = false; // Vypne tento skript, aby se skóre neaktualizovalo dále
        }

        scoreText.text = score.ToString("");
    }
}
