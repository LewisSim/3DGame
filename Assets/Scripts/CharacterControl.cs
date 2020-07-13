using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    float speed = 2f, speedLook = 2f;
    float moveZ, moveX, yaw, pitch;
    [SerializeField]
    GameObject cam;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {

        //Movement
        moveZ = Input.GetAxis("Vertical");
        moveX = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveX * speed, 0, moveZ * speed);


        var locVel = transform.TransformDirection(movement);
        

        //MouseLook
        yaw += speedLook * Input.GetAxis("Mouse X");
        pitch -= speedLook * Input.GetAxis("Mouse Y");

        //Do looking and moving
        rb.velocity = Vector3.ClampMagnitude(locVel, speed);
        transform.eulerAngles = new Vector3(0, yaw, 0);       
        cam.transform.eulerAngles = new Vector3(Mathf.Clamp(pitch, -40, 70), yaw, 0);
        



    }

}
