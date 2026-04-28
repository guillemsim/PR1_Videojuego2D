using UnityEngine;
using UnityEngine.InputSystem;

public class MovPersonaje : MonoBehaviour
{
    public float impulsoDeSalto = 5.0f;
    public float velocidad = 0.05f;
    Animator animator;
    bool puedoSaltar = false;
    Rigidbody2D rb;

    public void Muerte()
    {
        GameManager.vidas -= 1;
        //      transform.position = respawn.transform.position;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move
        Vector2 moveInput = InputSystem.actions["Move"].ReadValue<Vector2>();
        this.transform.Translate(moveInput.x * velocidad, 0, 0);

        //Animacion Mov
        if (moveInput.x != 0)
        {
            animator.SetBool("estaMoviendo", true);
            Debug.Log("True");
        }
        else
        {
            animator.SetBool("estaMoviendo", false);
            Debug.Log("False");
        }

        //Flip del personaje
        if (moveInput.x < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (moveInput.x > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
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