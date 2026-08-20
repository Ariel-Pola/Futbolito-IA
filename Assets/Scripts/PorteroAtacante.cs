using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteroAtacante : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 8f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movimiento = Vector3.zero;
        if (Input.GetKey(KeyCode.W) && transform.position.z > -4.42)
        {
            movimiento.z = -1;
        }
        else if (Input.GetKey(KeyCode.S) && transform.position.z < 4.42)
        {
            movimiento.z = +1;
        }
        Move(movimiento);
    }
    void Move(Vector3 direccion)
    {
        transform.position += direccion.normalized * speed * Time.deltaTime;
    }
}
