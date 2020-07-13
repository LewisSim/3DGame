using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayChecker : MonoBehaviour
{
    public bool doorHit;
    // Start is called before the first frame update
    void Start()
    {
        doorHit = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        int layerMask = 1 << 8;

        layerMask = ~layerMask;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            //Debug.Log("Did Hit");
            if (hit.transform.gameObject.tag == "Clickable")
            {
                doorHit = true;
            }
            else
            {
                doorHit = false;
            }
        }
    }
}
