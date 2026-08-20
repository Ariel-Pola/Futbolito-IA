using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlXbox : MonoBehaviour
{
    float speed = 5f;  // Velocidad de movimiento

    void Update()
    {
        // Leer la palanca izquierda sin cambiar configuración en Unity
        float horizontal = Input.GetAxis("Horizontal"); // Movimiento Izquierda-Derecha
        float vertical = Input.GetAxis("Vertical"); // Movimiento Arriba-Abajo

        // Crear vector de movimiento
        Vector3 movimiento = new Vector3(horizontal, 0, vertical);

        // Aplicar movimiento
        transform.position += movimiento * speed * Time.deltaTime;
    }
}
