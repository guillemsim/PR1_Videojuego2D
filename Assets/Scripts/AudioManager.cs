using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip clipBotones;
    public AudioClip bandaSonora;
    public AudioClip monedas;

    public GameObject AudioManagerObj;
    AudioSource AudioManagerSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManagerSource = AudioManagerObj.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() { }

    public void SonarBoton()
    {
        GetComponent<AudioSource>().PlayOneShot(clipBotones);
    }
}
