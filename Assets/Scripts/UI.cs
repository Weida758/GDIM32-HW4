using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI playerScoreTop;
    [SerializeField] TMPro.TextMeshProUGUI playerScore;

    [SerializeField] private GameObject gameOverPanel;

    private void Start()
    {
        GameController.Instance.player.OnPlayerScore += UpdateScore;
        GameController.Instance.player.OnPlayerDeath += ShowGameOverPanel;
    }

    private void UpdateScore()
    {
        playerScoreTop.text = GameController.Instance.player.score.ToString();
        playerScore.text = "Score: " + GameController.Instance.player.score;
    }
    
    private void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
