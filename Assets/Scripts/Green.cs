using UnityEngine;

public class Green : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.addScore(10);
    }
}
