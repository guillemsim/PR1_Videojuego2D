using UnityEngine;
using UnityEngine.InputSystem;

public class MovPersonaje : MonoBehaviour
{

    public float velocidad = 0.5f;
    public float impulsoDeSalto = 5.0f;

    Rigidbody2D rb;

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

        this.transform.Translate(moveInput.x*velocidad, moveInput.y, 0);

        //Flip
        if(moveInput.x < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(moveInput.x > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }

        //Salto

        bool salto = InputSystem.actions["Jump"].WasPressedThisFrame();

        if(salto == true)
        {
            rb.AddForce(transform.up*impulsoDeSalto,ForceMode2D.Impulse);

        }


    }
}
