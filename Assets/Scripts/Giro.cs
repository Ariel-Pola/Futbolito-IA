using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Giro : MonoBehaviour
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
        if (Input.GetKey(KeyCode.J))
        {
            rotacion.x = -1;
            
        }
        else if (Input.GetKey(KeyCode.L))
        {
            rotacion.x = +1;
        }
        Rotate(rotacion);
    }
    void Rotate(Vector3 direccion)
    {
        transform.Rotate (direccion * speed * Time.deltaTime);
    }
}
