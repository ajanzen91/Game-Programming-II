using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform[] points;
    public float moveSpeed;
    public float chargeSpeed;
    public bool isCharging;
    public bool[] chargePoints;
    private int destPoint = 0;
    private float currSpeed;

    // Start is called before the first frame update
    void Start()
    {
        if(!isCharging)
        {
            currSpeed = moveSpeed;
            chargePoints = null;
        }
        else if(chargePoints[destPoint] == false)
        {
            currSpeed = moveSpeed;
        }
        else
        {
            currSpeed = chargeSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.Equals(points[destPoint].position))
        {
            GoToNextPoint();
        }

        transform.position = Vector3.MoveTowards(transform.position, points[destPoint].position, currSpeed * Time.deltaTime);
    }

    void GoToNextPoint()
    {
        if (points.Length == 0)
        {
            return;
        }

        destPoint++;

        if(destPoint == points.Length)
        {
            destPoint = 0;
        }

        if(isCharging && (chargePoints[destPoint] == true))
        {
            currSpeed = chargeSpeed;
        }
        else
        {
            currSpeed = moveSpeed;
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "PatrolPoint")
    //    {
    //        GoToNextPoint();
    //    }
    //}
}
