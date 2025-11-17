using UnityEngine;

public enum CarType { Player, AI }
public class CarIdentify : MonoBehaviour
{
    public string displayName = "joku auto";
    public CarType type = CarType.AI;
}
