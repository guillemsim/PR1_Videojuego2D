using UnityEngine;

public class DiamanteScript : MonoBehaviour

{
    public GameObject Diamante;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Diamante.GetComponent<SpriteRenderer>().enabled = false;
        Diamante.GetComponent<Collider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(CofreScript.cofreAbierto == true)
        {
            Diamante.GetComponent<SpriteRenderer>().enabled = true;
            Diamante.GetComponent<Collider2D>().enabled = true;
        }
    }
        void OnTriggerEnter2D(Collider2D col)
    {
        //cofre
        if(col.gameObject.name == "Personaje")
        {
            Destroy(this.gameObject, 0.0f);
            GameManager.puntos = GameManager.puntos + 10;
            GameManager.gameOver.text = "Facilito Tutorial";
        }
    }
}
