using UnityEngine;
using UnityEngine.InputSystem;


public class EnemigoScript : MonoBehaviour
{
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("destruirEnemigo", false);
    }

    // Update is called once per frame
    void Update()
    {
         //Marranería
        if(InputSystem.actions["Crouch"].WasPressedThisFrame())
        {
            Destroy(this.gameObject, 0.5f);
            Debug.Log("Enemigo destruido");
            animator.SetBool("destruirEnemigo", true);
            LlaveScript.enemigoMuerto = true;
        }
    }
        void OnTriggerEnter2D(Collider2D col)
    {
        //DMG
        if(col.gameObject.name == "Personaje")
        {
            GameManager.vidas = GameManager.vidas - 1;
            Debug.Log("Personaje golpeado");
            
        }
        //Destruir enemigo
        if(col.gameObject.name == "bala(Clone)" || col.gameObject.name == "bala" || col.gameObject.name == "balaPrefab")
        {
            Destroy(this.gameObject, 0.5f);
            Debug.Log("Enemigo destruido");
            animator.SetBool("destruirEnemigo", true);
        }
    }
}
