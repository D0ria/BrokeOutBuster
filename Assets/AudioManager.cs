using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;

    public AudioClip background;
    public AudioClip pam;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySfx(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

}
