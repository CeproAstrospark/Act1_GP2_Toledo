using UnityEngine;

public class Red : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drone"))
        {
            GameManager.Instance.deductScore(10);
            Debug.Log("score = " + GameManager.Instance.score);
        }
        
    }
}
