using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 50f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
    }
}
