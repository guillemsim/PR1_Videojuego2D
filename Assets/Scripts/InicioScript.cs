using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioScript : MonoBehaviour
{
    public GameObject panelInicio;
    public GameObject panelSettings;
    public GameObject AudioManagerObj;

    AudioSource AudioManagerSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panelSettings.SetActive(false);
    }

    // Update is called once per frame
    void Update() { }

    public void showSettings()
    {
        panelSettings.SetActive(false);
        panelInicio.SetActive(true);
        AudioManagerObj.GetComponent<AudioSource>().PlayOneShot(AudioManager.clipBotones);
    }

    public void exitSettings()
    {
        panelSettings.SetActive(false);
        panelInicio.SetActive(true);
        AudioManagerObj.GetComponent<AudioManager>().SonarBoton();
    }

    public void Inicio()
    {
        SceneManager.LoadScene("Juego");
    }
}
