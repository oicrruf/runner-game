using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cod_Ejemplo : MonoBehaviour
{
    //Variables Globales
    public int vida = 3;
    private float velocidad = 20; 
    
    // Start is called before the first frame update
    void Start()
    {
        //Variables locales
        int defensa = 10;
        Debug.Log("Mi velocidad es: "+ ObtenerVelocidad() + " y mi defensa es: "+ defensa);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private float ObtenerVelocidad()
    {
        return velocidad;
    }

    
}
