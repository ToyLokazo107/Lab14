using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_enemigos : MonoBehaviour
{
    public GameObject prefapenemigos;
    public float contador;
    public float limite;
    public float max;
    public float min;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (contador > limite)
        {
            float ubicacion = Random.Range(min, max);
            Instantiate(prefapenemigos, new Vector2(ubicacion, transform.position.y), transform.rotation);
            contador = 0;
        } 
        contador = contador + Time.deltaTime;
    }
}
