using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //coin
        if(col.gameObject.name == "Personaje")
        {
        gameObject.GetComponent<Animator>().SetBool("obtenerCoin", true);
        Destroy(this.gameObject, 3.0f);
        }
    }
}
