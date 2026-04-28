using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioScript : MonoBehaviour
{

    public void InicioJuego(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void ExitJuego()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
