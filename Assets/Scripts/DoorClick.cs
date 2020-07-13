using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClick : MonoBehaviour
{
    public GameObject raycaster;
    RayChecker rayChecker;
    public GameObject door;
    HingeJoint hinge;
    JointSpring hinger;

    bool isDoorHit;
    // Start is called before the first frame update
    void Start()
    {
        rayChecker = raycaster.GetComponent<RayChecker>();
        hinge = door.GetComponent<HingeJoint>();
        hinger = hinge.spring;
    }

    // Update is called once per frame
    void Update()
    {
        isDoorHit = rayChecker.doorHit;

        if (isDoorHit)
        {
            if (Input.GetMouseButtonDown(0))
            {
                hinger.targetPosition = 90f;
                hinge.spring = hinger;
            }
        }
    }

}
