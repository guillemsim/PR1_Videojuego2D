using UnityEngine;

public class LlaveScript : MonoBehaviour

{
    public static bool enemigoMuerto = false;
    public static bool llaveObtenida = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       GetComponent<SpriteRenderer>().enabled = false;
       GetComponent<Collider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemigoMuerto == true)   
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<Collider2D>().enabled = true;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //llave
        if(col.gameObject.name == "Personaje")
        {
        llaveObtenida = true;
        Destroy(this.gameObject, 0.0f);
        }
    }
}
