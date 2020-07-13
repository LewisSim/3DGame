using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door;
    HingeJoint hinge;
    JointSpring hinger;


    // Start is called before the first frame update
    void Start()
    {
        hinge = door.GetComponent<HingeJoint>();
        hinger = hinge.spring;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            hinger.targetPosition = 90f;
            hinge.spring = hinger;
        }
    }
}
