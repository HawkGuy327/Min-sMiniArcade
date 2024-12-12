using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int playerScore;
    private int computerScore;
    public Text playerScoreText;
    public Text cpuScoreText;
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle cpuPaddle;
    public int winScore;

    public void PlayerScores()
    {
        playerScore++;

        this.playerScoreText.text = playerScore.ToString();

        ResetRound();
        if (playerScore == winScore)
        {
            SceneManager.LoadScene("P1 Win");
        }

    }
    public void ComputerScores()
    {
        computerScore++;
        
        this.cpuScoreText.text = computerScore.ToString();

        ResetRound();
        if (computerScore == winScore)
        {
            SceneManager.LoadScene("CPU Win");
        }
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.cpuPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}