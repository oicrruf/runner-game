using UnityEngine;

public class Cod_Escenario : MonoBehaviour
{
    public Transform[] modulos;
    public Transform[] colliderModulos; //Exit
    public int ultimoModulo=5;
    public float desface = 4.49f;

    private Transform moduloTemp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MoverModulo(Transform modulo_arg)
    {
        //Debug.Log(modulo_arg.name);
        moduloTemp = modulo_arg;
        Invoke("MoverEntorno", 1);
        
    }

    void MoverEntorno()
    {
        for (int i = 0; i < modulos.Length; i++)
        {
            if (moduloTemp.GetInstanceID() == modulos[i].GetInstanceID())
            {
                if (i == 0)
                {
                    ultimoModulo = modulos.Length - 1;
                }
                else
                {
                    ultimoModulo = i - 1;
                }
                break;
            }
        }

        moduloTemp.position = new Vector3(0, 0, colliderModulos[ultimoModulo].position.z) + new Vector3(0, 0, desface);
    }

}
