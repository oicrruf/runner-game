using UnityEngine;

public class cod_Controlar : MonoBehaviour
{
    public Transform objeto;
    public Vector3 direccion;
    public int min, seg;
    private int contadorTiempo;
    public cod_PersonajeControlador pj;

    void Start()
    {
        pj.tipoPersonaje = 5;
        //Destroy(objeto.gameObject, 5.1f);
        InvokeRepeating("Reloj", 0.1f, 0.2f);
    }

    void Update()
    {
        //objeto.Translate(direccion* Time.deltaTime);
        if(Input.GetKey(KeyCode.Space))
        {
            objeto.Rotate(direccion * Time.deltaTime);
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            direccion *= 2;
            //direccion = direccion * 2;
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            Invoke("Escalar", 2.3f);//Le decimos a C# que este numero es de tipo float (decimal)
        } 
        
    }

    /// <summary>
    /// Este metodo sirve para escalar mi cubo
    /// </summary>
    void Escalar()
    {
        objeto.localScale += direccion;
        Debug.Log("Fui llamado");
    }

    void Reloj()
    {
        contadorTiempo += 1;
        if(contadorTiempo>59)
        {
            contadorTiempo = 0;
            min += 1;
        }
        seg = contadorTiempo;
        Debug.Log("Minutos: " + min.ToString() + " : " + seg.ToString());
    }

}
