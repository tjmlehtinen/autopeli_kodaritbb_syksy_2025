using UnityEngine;

public class LapCheck : MonoBehaviour
{
    public int checkpointCount;
    private bool[] visited;
    private int visitCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        visited = new bool[checkpointCount];
        visitCount = 0;
    }

    public void MarkVisited(int index)
    {
        if (!visited[index])
        {
            visited[index] = true;
            visitCount += 1;
        }
    }

    public bool AllVisited()
    {
        return visitCount == checkpointCount;
    }
}
