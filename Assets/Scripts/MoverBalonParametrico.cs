using System.Collections;
using UnityEngine;

public class MoverBalonParametrico : MonoBehaviour
{
    public Vector3 posicionInicial;  
    public Vector3 posicionFinal;    
    public float velocidad;          
    public float gravedad = 9.81f;   
    private float tiempo;            
    private Vector3 velocidadInicial; 
    

    void Start()
    {
        

        posicionInicial= transform.position;

        
        Vector3 direccion = (posicionFinal - posicionInicial).normalized;
        velocidadInicial.x = direccion.x * velocidad;
        velocidadInicial.z = direccion.z * velocidad;
        velocidadInicial.y = Mathf.Sqrt(2 * gravedad * (posicionFinal.y - posicionInicial.y));
    }

    void Update()
    {
        
        tiempo += Time.deltaTime;

        
        float nuevoX = posicionInicial.x + velocidadInicial.x * tiempo;
        float nuevoY = posicionInicial.y + velocidadInicial.y * tiempo - 0.1f * gravedad * Mathf.Pow(tiempo, 2);
        float nuevoZ = posicionInicial.z + velocidadInicial.z * tiempo;

        if (nuevoY < 0) nuevoY = 0;

    
        transform.position = new Vector3(nuevoX, nuevoY, nuevoZ);

        if (Vector3.Distance(transform.position, posicionFinal) < 0.1f)
        {
            Debug.Log("El balón ha llegado a su destino.");
        }
    }
}
