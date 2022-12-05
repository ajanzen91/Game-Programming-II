using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class InstantiatePlayer : MonoBehaviour
{
    public GameObject playerObj;
    public GameObject playerCam;
    public GameObject playerFollowCam;

    // Start is called before the first frame update
    void Start()
    {
        //playerObj = Instantiate(playerObj);
        //playerObj.transform.position = transform.position;

        //playerFollowCam = Instantiate(playerFollowCam);
        //playerFollowCam.transform.position = new Vector3((float)(playerObj.transform.position.x + .2), (float)(playerObj.transform.position.y + 1.375), (float)(playerObj.transform.position.z - 4));

        //playerCam.transform.position = new Vector3((float)(playerObj.transform.position.x + .2), (float)(playerObj.transform.position.y + 1.375), (float)(playerObj.transform.position.z - 4));
        //playerFollowCam.GetComponent<CinemachineVirtualCamera>().LookAt = playerObj.transform;
        //playerFollowCam.GetComponent<CinemachineVirtualCamera>().Follow = playerObj.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
