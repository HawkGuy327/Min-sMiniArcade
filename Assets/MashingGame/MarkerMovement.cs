using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MarkerMovement : MonoBehaviour
{
    public float distance = 0.1f;
    public int winNumber = 7;
    public int WINnumber = 5;
    public float num;
    float timer = 0;
    int pScore = 0;
    int cScore = 0;
    public Text playerScoreText;
    public Text cpuScoreText;

    void resetState ()
    {
        this.transform.position = Vector3.zero;
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) {
            this.transform.position += Vector3.left * distance;
        }
        if (timer >= num)
        {
            this.transform.position += Vector3.right * distance;
            timer = 0;
        }

        if (this.transform.position.x <= (winNumber * distance) * -1)
        {
            resetState();
            pScore++;
            this.playerScoreText.text = pScore.ToString();
            if (pScore == WINnumber)
            {
                SceneManager.LoadScene("P1 Win");
            }
        }
        else if (this.transform.position.x >= winNumber * distance)
        {
            resetState();
            cScore++;
            this.cpuScoreText.text = cScore.ToString();
            if (cScore == WINnumber)
            {
                SceneManager.LoadScene("CPU Win");
            }
        }
        timer += Time.deltaTime;

    }
}
