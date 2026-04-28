using UnityEngine;
using UnityEngine.InputSystem;

public class MovPersonaje : MonoBehaviour
{
    public float impulsoDeSalto = 5.0f;
    public float velocidad = 0.05f;
    Animator animator;
    bool puedoSaltar = false;
    public static int direccion = 1;
    Rigidbody2D rb;
    GameObject Spawn; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        Spawn = GameObject.Find("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        //Muerte
           if (GameManager.vidas <= 0)
        {
            transform.position = Spawn.transform.position;
            GameManager.gameOver.text = "Game Over";
            GetComponent<SpriteRenderer>().enabled = false;
        }
        //Move
        Vector2 moveInput = InputSystem.actions["Move"].ReadValue<Vector2>();
        this.transform.Translate(moveInput.x * velocidad, 0, 0);

        //Animacion Mov
        if (moveInput.x != 0)
        {
            animator.SetBool("estaMoviendo", true);
            //Debug.Log("True");
        }
        else
        {
            animator.SetBool("estaMoviendo", false);
            //Debug.Log("False");
        }

        //Flip del personaje
        if (moveInput.x < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            direccion = -1;
        }
        else if (moveInput.x > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            direccion = 1;
        }

        //Raycasting
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);

        if (hit.collider == true)
        {
            puedoSaltar = true;
        }
        else
        {
            puedoSaltar = false;
        }


        //Salto
        bool salto = InputSystem.actions["Jump"].WasPressedThisFrame();

        if (salto == true && puedoSaltar == true)
        {
            rb.AddForce(transform.up * impulsoDeSalto, ForceMode2D.Impulse);
        }
    }
}