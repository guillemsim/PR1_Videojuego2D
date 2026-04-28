using UnityEngine;

public class KillPlaneScript : MonoBehaviour
{
    GameObject Spawn;
    GameObject Personaje;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn = GameObject.Find("Spawn");
        Personaje = GameObject.Find("Personaje");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnTriggerEnter2D(Collider2D col)
    {
        //killplane
        if(col.gameObject.name == "Personaje")
        {
            Personaje.transform.position = Spawn.transform.position;
            GameManager.vidas = GameManager.vidas - 1;
            Debug.Log("Personaje ha caido en el KillPlane");
        }
    }
}
