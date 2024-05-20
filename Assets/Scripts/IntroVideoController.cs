using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class IntroVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Le VideoPlayer de la cin�matique

    void Start()
    {
        // Ajout de l'�v�nement pour d�tecter la fin de la vid�o
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // M�thode appel�e lorsque la vid�o se termine
    void OnVideoEnd(VideoPlayer vp)
    {
        // Charger la sc�ne du menu principal
        SceneManager.LoadScene("Menu");
    }
}
