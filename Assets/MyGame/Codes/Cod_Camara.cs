using UnityEngine;

public class Cod_Camara : MonoBehaviour
{
    public Transform personaje;
    public Vector3 distancia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(transform.position.x, personaje.position.y, personaje.position.z) + distancia;
    }
}
