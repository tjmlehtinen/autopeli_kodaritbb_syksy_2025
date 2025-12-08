using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    public int orderIndex;

    private void OnTriggerEnter(Collider auto)
    {
        LapCheck validator = auto.GetComponent<LapCheck>();
        if (validator != null)
        {
            validator.MarkVisited(orderIndex);
        }
    }
    
}
