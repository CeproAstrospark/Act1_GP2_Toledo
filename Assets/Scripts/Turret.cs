using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform target;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = (target.position - transform.position).normalized;
        Quaternion targetRot = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, speed * Time.fixedDeltaTime);
    }
}
