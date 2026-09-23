using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject drone;
    public int score;
    public bool isDroneDead = false;
    public bool isRed = false;

    // Singleton Instance
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        // Check if another GameManager already exists
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // Set this GameManager as the Singleton instance
        Instance = this;

        // Optional: keep GameManager when changing scenes
        DontDestroyOnLoad(gameObject);
    }

    public void addScore(int value)
    {
        score += value;
    }

    public void deductScore(int value)
    {
        score -= value;
    }

    private void Update()
    {
        if (isDroneDead)
        {
            drone.SetActive(true);
            drone.transform.position = new Vector3(5.39f, 1.12f, 0.51f);

            isDroneDead = false;
        }

        scoreText.text = "Score: " + score;
    }
}