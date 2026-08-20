using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBalon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform destinoPelota;
    public float velocidad;
    private float lado = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -13 && transform.position.x<-1.46)
        {
            float paso = velocidad * Time.deltaTime;
            transform.position = Vector3.MoveTowards(
                transform.position, destinoPelota.position, paso);
            Vector3 nuevaPosicíon = Vector3.zero;
            nuevaPosicíon.y -= 0.01f;
            nuevaPosicíon.z += lado;
            destinoPelota.position += nuevaPosicíon.normalized * velocidad * Time.deltaTime;
            if (transform.position.z > 4)
                lado = -0.1f;
        }
    }
}
