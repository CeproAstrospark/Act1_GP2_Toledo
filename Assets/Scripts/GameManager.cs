using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int score;
    public static GameManager Instance;
    public bool isDroneDead = false;

    private void Awake()
    {
        Instance = this;
    }

    public void addScore(int value)
    {
        score += value;
    }

    public void deductScore(int value)
    {
        score -= value;
    }

    

    
}
