using System.Collections;
using UnityEngine;

public class BalonParametricoConRebote : MonoBehaviour
{
    public float velocidad = 5.0f;   // Velocidad del balón
    public float gravedad = 9.81f;   // Gravedad que afecta al movimiento
    private Vector3 direccion;       // Dirección del movimiento del balón
    private float tiempo;            // Tiempo transcurrido

    void Start()
    {
        
        direccion = new Vector3(Random.Range(-1f, 1f), Random.Range(-0.5f, 0.5f), Random.Range(-1f, 1f)).normalized;

        
        tiempo = 0f;
    }

    void Update()
    {
        
        tiempo += Time.deltaTime;

        
        float nuevoX = transform.position.x + direccion.x * velocidad * Time.deltaTime;
        float nuevoY = transform.position.y + direccion.y * velocidad * Time.deltaTime - 0.5f * gravedad * Mathf.Pow(tiempo, 2);
        float nuevoZ = transform.position.z + direccion.z * velocidad * Time.deltaTime;

        if (nuevoY < 1) nuevoY = 1;

        transform.position = new Vector3(nuevoX, nuevoY, nuevoZ);

        AplicarRotacion();

       
        if (Vector3.Distance(transform.position, Vector3.zero) < 0.1f)
        {
            Debug.Log("El balón ha llegado a su destino.");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
        Vector3 normal = collision.contacts[0].normal;

        direccion = Vector3.Reflect(direccion, normal).normalized;

        tiempo = 0f;

        Debug.Log("Rebote con: " + collision.gameObject.name);
    }

    void AplicarRotacion()
    {

        Vector3 ejeRotacion = Vector3.Cross(Vector3.up, direccion).normalized;


        float velocidadRotacion = velocidad * Time.deltaTime * 180 / (2 * Mathf.PI * 0.2f); 

        transform.Rotate(ejeRotacion, velocidadRotacion);
    }
}
