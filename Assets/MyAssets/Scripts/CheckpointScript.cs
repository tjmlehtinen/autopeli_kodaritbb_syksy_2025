using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    public int orderIndex;

    private void OnTriggerEnter(Collider auto)
    {
        //Debug.Log(auto.name + " osui checkpointtiin " + orderIndex);
        LapCheck validator = auto.GetComponent<LapCheck>();
        if (validator != null)
        {
            validator.MarkVisited(orderIndex);
            Debug.Log("merkattu " + orderIndex);
        }
    }
    
}
