using UnityEngine;
using UnityEngine.InputSystem;

public class MovPersonaje : MonoBehaviour
{
    public float velocidad = 0.05f;
    public float impulsoDeSalto = 5.0f;

    Rigidbody2D rb;
    bool puedoSaltar = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move
        Vector2 moveInput = InputSystem.actions["Move"].ReadValue<Vector2>();
        this.transform.Translate(moveInput.x * velocidad, 0, 0);

        //Flip
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
        Debug.Log(hit.collider.name);
        //Salto
        bool salto = InputSystem.actions["Jump"].WasPressedThisFrame();

        if (salto == true && puedoSaltar == true)
        {
            rb.AddForce(transform.up * impulsoDeSalto, ForceMode2D.Impulse);
        }
    }

    public void Muerte()
    {
        GameManager.vidas -= 1;
        //      transform.position = respawn.transform.position;
    }
}
