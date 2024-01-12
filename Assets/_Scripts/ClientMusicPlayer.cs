using UnityEngine;

[RequireComponent (typeof(AudioSource))]
public class ClientMusicPlayer : Singleton<ClientMusicPlayer>
{
    private AudioSource _audioSource;

    [SerializeField] private AudioClip nomAudioClip;

    public override void Awake()
    {
        base.Awake();
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayNomAudioClip()
    {
        _audioSource.clip = nomAudioClip;
        _audioSource.Play();
    }
}
