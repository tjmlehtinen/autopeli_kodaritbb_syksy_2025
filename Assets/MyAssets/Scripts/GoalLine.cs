using UnityEngine;

public class GoalLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider auto)
    {
        CarIdentify carID = auto.GetComponent<CarIdentify>();
        string carName = carID.displayName;
        if (carID.type == CarType.Player)
        {
            LapCheck validator = auto.GetComponent<LapCheck>();
            if (validator.AllVisited())
            {
                Debug.Log("pelaaja ylitti maaliviivan, ja checkpointit käyty");
            }
            else
            {
                Debug.Log("pelaaja ylitti maaliviivan, mutta checkpointteja puuttuu");
            }
        }

        Debug.Log("Maaliviivan ylitti " + carName);
    }
}
