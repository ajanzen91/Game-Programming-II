using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShellController : MonoBehaviour
{
    public Transform[] points;
    public float moveSpeed;

    private NavMeshAgent agent;
    private int destPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        GoToNextPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if(!agent.pathPending && agent.remainingDistance < 2f)
        {
            GoToNextPoint();
        }
    }

    private void GoToNextPoint()
    {
        if(points.Length == 0)
        {
            return;
        }

        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
    }
}
