using UnityEngine;
using UnityEngine.UI;

public class Cod_Personaje : MonoBehaviour
{
    public Text puntos;
    public float velocidad;
    public Animator _ani;
    public Rigidbody _rb;
    public int carril;

    private Cod_Escenario _escenario;
    private bool estaDetenido;
    private int cantidadPuntos;
    // Start is called before the first frame update
    void Start()
    {
        _escenario = GetComponent<Cod_Escenario>();
        if (_escenario == null)
            Debug.Log("Escenario no encontrado");

        _ani = this.GetComponent<Animator>();
        if (_ani == null)
            Debug.LogError("Animator no encontrado");
        else
        {
            _ani.Play("runStart");
        }

        _rb = this.GetComponent<Rigidbody>();
        if (_rb == null)
            Debug.LogError("Rigidbody no encontrado");

    }

    // Update is called once per frame
    void Update()
    {
        if(estaDetenido == false)
        {
            _rb.velocity = this.transform.forward * velocidad;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(carril<2)
                carril++;

            CambiarCarril();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(carril>0)
                carril--;

            CambiarCarril();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        { 
            Application.Quit();
        }
    }

    void CambiarCarril()
    {
        switch(carril)
        {
            case 0:
                transform.position = new Vector3(-1, transform.position.y, transform.position.z);
                break;

            case 1:
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
                break;

            case 2:
                transform.position = new Vector3(1, transform.position.y, transform.position.z);
                break;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name== "Exit")
        {
            _escenario.MoverModulo(col.transform.parent.transform.parent.transform);
        }
        if(col.gameObject.CompareTag("Pez"))
        {
            cantidadPuntos++;
            puntos.text = "Puntos: " + cantidadPuntos.ToString();
            Destroy(col.gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        _rb.velocity = Vector3.zero;
        _rb.constraints = RigidbodyConstraints.FreezeAll;
        estaDetenido = true;
        _ani.SetTrigger("Hit");
        _ani.SetBool("Dead", true);
    }
}
