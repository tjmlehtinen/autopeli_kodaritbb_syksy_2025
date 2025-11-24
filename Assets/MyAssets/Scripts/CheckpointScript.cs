using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    public int orderIndex;

    private void OnTriggerEnter(Collider auto)
    {
        Debug.Log(auto.name + " osui checkpointtiin " + orderIndex);
    }
    
}
