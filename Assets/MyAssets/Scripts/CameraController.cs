using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera topCamera;
    public Camera inCarCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        topCamera.enabled = true;
        inCarCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            topCamera.enabled = !topCamera.enabled;
            inCarCamera.enabled = !inCarCamera.enabled;
        }
    }
}
