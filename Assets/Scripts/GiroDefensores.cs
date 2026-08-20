using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroDefensores : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 300f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotacion = Vector3.zero;
        if (Input.GetKey(KeyCode.Keypad6))
        {
            rotacion.x = +1;

        }
        else if (Input.GetKey(KeyCode.Keypad4))
        {
            rotacion.x = -1;
        }
        Rotate(rotacion);
    }
    void Rotate(Vector3 direccion)
    {
        transform.Rotate(direccion * speed * Time.deltaTime);
    }
}
