using UnityEngine;

public class CofreScript : MonoBehaviour
{
    public static bool cofreAbierto = false;
    public GameObject CofreCerrado;
    public GameObject CofreAbierto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       CofreAbierto.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
        void OnTriggerEnter2D(Collider2D col)
    {
        //cofre
        if(col.gameObject.name == "Personaje" && LlaveScript.llaveObtenida == true)
        {
        Destroy(CofreCerrado, 0.0f);
        CofreAbierto.GetComponent<SpriteRenderer>().enabled = true;
        cofreAbierto = true;
        }
    }
}
