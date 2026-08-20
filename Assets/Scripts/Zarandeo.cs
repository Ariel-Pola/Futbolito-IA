using System.Collections;
using UnityEngine;

public class ZarandeoCancha : MonoBehaviour
{
    public float fuerzaZarandeo = 2.0f;  // Fuerza del zarandeo
    public float duracionZarandeo = 0.5f; // Duración del zarandeo en segundos

    private bool zarandeando = false;  // Estado para verificar si ya se está zarandeando
    private Vector3 posicionInicial;   // Posición inicial de la cancha para volver a ella después del zarandeo

    void Start()
    {
        // Guardar la posición inicial de la cancha
        posicionInicial = transform.position;
    }

    void Update()
    {
        // Detectar la presión de la tecla "P" para iniciar el zarandeo
        if (Input.GetKeyDown(KeyCode.P) && !zarandeando)
        {
            StartCoroutine(Zarandear());
        }
    }

    IEnumerator Zarandear()
    {
        zarandeando = true;
        float tiempoTranscurrido = 0f;

        // Realizar el zarandeo durante la duración especificada
        while (tiempoTranscurrido < duracionZarandeo)
        {
            // Mover ligeramente la cancha para simular el zarandeo
            Vector3 desplazamiento = new Vector3(Random.Range(-0.1f, 0.1f), 0, Random.Range(-0.1f, 0.1f));
            transform.position += desplazamiento;

            // Esperar un pequeño tiempo antes de aplicar el siguiente movimiento
            yield return new WaitForSeconds(0.05f);

            // Volver la cancha a su posición original antes de aplicar el siguiente movimiento
            transform.position = posicionInicial;

            tiempoTranscurrido += 0.05f;
        }

        // Asegurarse de que la cancha termine en la posición inicial
        transform.position = posicionInicial;

        zarandeando = false;
    }
}

