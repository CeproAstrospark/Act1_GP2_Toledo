using UnityEngine;

public class Drone : MonoBehaviour
{
    public Transform targetA;
    public Transform targetB;
    public float speed;
    private bool toB = true;
    private bool toA = false;


    private void OnMouseDown()
    {
        GameManager.Instance.addScore(10);
    }

    void Update()
    {
        if (toB)
        {

            Vector3 directionToTargetB = targetB.position - transform.position;
            
                Vector3 normalizeDirection = directionToTargetB.normalized;
                transform.position += normalizeDirection * speed * Time.fixedDeltaTime;

                if (Vector3.Distance(transform.position, targetB.position) < 0.1f)
                {
                    transform.position = targetB.position;
                    toB = false;
                    toA = true;
                }
            
            
        }

        if (toA)
        {
            Vector3 directionToTargetA = targetA.position - transform.position;

                Vector3 normalizeDirection = directionToTargetA.normalized;
                transform.position += normalizeDirection * speed * Time.fixedDeltaTime;


                if (Vector3.Distance(transform.position, targetA.position) < 0.1f)
                {
                    transform.position = targetA.position;
                    toB = true;
                    toA = false;
                }
            
            
        }

    }
}
