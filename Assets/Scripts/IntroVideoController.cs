using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class IntroVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Le VideoPlayer de la cinématique

    void Start()
    {
        // Ajout de l'événement pour détecter la fin de la vidéo
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // Méthode appelée lorsque la vidéo se termine
    void OnVideoEnd(VideoPlayer vp)
    {
        // Charger la scène du menu principal
        SceneManager.LoadScene("Menu");
    }
}
