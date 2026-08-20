using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Portero : MonoBehaviour
{
    float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movimiento = Vector3.zero;
        if (Input.GetKey(KeyCode.I)&&transform.position.z> -4.42)
        {
            movimiento.z = -1;
        }
        else if (Input.GetKey(KeyCode.K)&& transform.position.z < 4.42)
        {
            movimiento.z = +1;
        }
        Move(movimiento);
    }
    void Move(Vector3 direccion)
    {
        transform.position += direccion.normalized * speed* Time.deltaTime;
    }
}
