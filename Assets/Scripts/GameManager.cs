using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI TextScore1;
    public TextMeshProUGUI TextScore2;
    public BallMovement ball;

    // Start is called before the first frame update
    void Start()
    {
        // Register a BallMovement observer
        ball.OnGoal += OnGoalDelegate;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnGoalDelegate(object sender, EventArgs e)
    {
        OnGoalArgs args = e as OnGoalArgs;

        if (args.player == PlayerType.PLAYER1)
        {
            int score = int.Parse(TextScore1.text);
            TextScore1.text = (score + 1).ToString();
        }
        else
        {
            int score = int.Parse(TextScore2.text);
            TextScore2.text = (score + 1).ToString();
        }
    }
}