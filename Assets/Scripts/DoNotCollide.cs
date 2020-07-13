using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotCollide : MonoBehaviour
{

    public GameObject frame;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(frame.GetComponent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
