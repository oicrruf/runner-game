using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cod_Generador : MonoBehaviour
{
    public Transform personaje;
    public float distancia;
    public Transform[] prefabs;// pez, cono, tacho metal, tacho plastico
    public float rnd;
    // Start is called before the first frame update
    void Start()
    {
        distancia = transform.position.z - personaje.position.z;
        Debug.Log(distancia);
        Invoke("GenerarPrefab", Random.Range(0.22f,5.0f));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, personaje.position.z + distancia);
    }

    void GenerarPrefab()
    {
        rnd = Random.Range(1.5f, 3.0f);
        Instantiate(prefabs[Random.Range(0,4)], transform.position, transform.rotation);
        Invoke("GenerarPrefab", rnd);
    }
}
