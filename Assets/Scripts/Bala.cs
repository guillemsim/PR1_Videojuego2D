using UnityEngine;
using UnityEngine.InputSystem;

public class Bala : MonoBehaviour
{
    public GameObject BalaPrefab;
    public GameObject Arma;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Movimiento de la bala
        transform.Translate(0.01f * MovPersonaje.direccion, 0, 0);

        //tiempo de vida de la bala
        Destroy(this.gameObject, 0.5f);
    }

    
}
