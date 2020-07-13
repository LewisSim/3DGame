using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRed : MonoBehaviour
{

    public GameObject door;
    Material mat_instance;
    Material[] material_m;


    // Start is called before the first frame update
    void Start()
    {
        material_m = door.GetComponent<Renderer>().materials;
        mat_instance = new Material(material_m[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            material_m[1].color = Color.red;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            material_m[1].color = mat_instance.color;
        }
    }

}
