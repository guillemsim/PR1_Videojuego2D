using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int vidas = 3;
    public static int puntos = 0;
    TextMeshProUGUI puntosObjeto;
    TextMeshProUGUI vidasObjeto;
    public static TextMeshProUGUI gameOver;
    GameObject Spawn;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntosObjeto = GameObject.Find("puntosObjeto").GetComponent<TextMeshProUGUI>();
        vidasObjeto = GameObject.Find("vidasObjeto").GetComponent<TextMeshProUGUI>();
        gameOver = GameObject.Find("gameOver").GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        puntosObjeto.text = puntos.ToString();
        vidasObjeto.text = vidas.ToString();

        Debug.Log("Puntos: " + puntos);
        Debug.Log("Vidas: " + vidas);

    }
}
