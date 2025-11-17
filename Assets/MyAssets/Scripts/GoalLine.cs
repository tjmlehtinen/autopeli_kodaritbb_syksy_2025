using UnityEngine;

public class GoalLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider auto)
    {
        CarIdentify carID = auto.GetComponent<CarIdentify>();
        string carName = carID.displayName;
        Debug.Log("Maaliviivan ylitti " + carName);
    }
}
