using UnityEngine;

public class AICar : MonoBehaviour
{
    public Transform[] waypoints;
    private int nextIndex = 0;
    public float speed = 10f;
    public float turnSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform target = waypoints[nextIndex];
        Vector3 targetXZ = new Vector3(target.position.x, transform.position.y, target.position.z);
        Vector3 direction = (targetXZ - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, turnSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetXZ) < 1f)
        {
            nextIndex = (nextIndex + 1) % waypoints.Length;
        }
    }
}
