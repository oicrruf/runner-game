using UnityEngine;

public class cod_PersonajeControlador : MonoBehaviour
{
    #region variables publicas
    public float velocidad;//Velocidad en la que se mueve el personaje.
    [SerializeField] Animator anim; //Componente de animacion

    [HideInInspector] public int tipoPersonaje;
    #endregion


    private int _vel;

    #region Metodos predeterminados
    void Start()
    {
        
    }

    void Update()
    {
        float v = Input.GetAxis("Vertical");// -1 , 1
        float h = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(h, 0, v)*Time.deltaTime* velocidad);
        
        if(v!= 0 || h !=0) //estas en movimiento
        {
            anim.SetBool("Mover", true);
        }
        else //estas quieto
        {
            anim.SetBool("Mover", false);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Salto");
        }
    }
    #endregion

    /// <summary>
    /// Mover jugador
    /// </summary>
    /// <param name="num_arg"></param>
    void MovePlayer(int num_arg)
    {
        int num2;

    }

    void OnMouseDown()
    {
        MeshRenderer rend = this.GetComponent<MeshRenderer>();
        if (rend == null)
            Debug.LogError("MeshRenderer no fue encontrado");
        else
        {
            rend.enabled = !rend.enabled;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name != "Plane")
        {
            Debug.Log(col.gameObject.name);
        } 
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Estoy en un area");
    }
}
