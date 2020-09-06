using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cod_Hilos : MonoBehaviour
{
    private int tiempo=0; 
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("ShowMsg", 2.1f); //Invocar con retraso
        //InvokeRepeating("MostrarTiempo", 1, 0.1f); //Invocar repetidamente con retraso
        StartCoroutine(SegundoHilo()); //Ejecución en paralelo
        
    }

    void ShowMsg()
    {
        Debug.Log("Mostrar");
    }

    void MostrarTiempo()
    {
        tiempo+=1;
        Debug.Log("Time: " + tiempo.ToString());
        if (tiempo >= 60)
            CancelInvoke("MostrarTiempo");
    }

    IEnumerator SegundoHilo()
    {
        Debug.Log("yo muestro esto");
        yield return new WaitForSeconds(2f);
        Debug.Log("espere 2 segundos");
        Debug.Log("y estoy aca");
    }


}
