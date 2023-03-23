using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScores : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText = null;

    private long score = 0;

    public void IncreasePoints(int multiplier)
    {
        score += 1 * multiplier;

        UpdateUI();
    }

    public void DecreasePoints(int amount)
    {
        score -= amount;
    }

    public void SetPoints(int amount)
    {
        score = amount;
    }

    private void UpdateUI()
    {
        scoreText.text = "Points: " + score;
    }
}
