using UnityEngine;
using UnityEngine.UI; // Necessary to talk to the UI Text
using UnityEngine.SceneManagement;
using TMPro; // 1. Add this line!

public class GameLogic : MonoBehaviour
{
    public int health = 100;
    public int score = 0;
    public TextMeshProUGUI healthDisplay;
    public TextMeshProUGUI scoreDisplay;

    void Start()
    {
        UpdateUI();
    }

    // This runs when the Player overlaps with the Obstacle Trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Obstacle")
        {
            health -= 10;
            score += 5; // Increase score for surviving a hit
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        healthDisplay.text = "Health: " + health;
        scoreDisplay.text = "Score: " + score;
    }
}