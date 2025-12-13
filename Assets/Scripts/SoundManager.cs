using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }

    [SerializeField] private AudioClip hitSound;
    [SerializeField] private AudioClip deathEnemySound;
    [SerializeField] private AudioClip deathSound;
    [SerializeField] private AudioClip JumpSound;
    [SerializeField] private float _volume;

    private AudioSource audioSource;

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        audioSource = GetComponent<AudioSource>();

        
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();
    }

    

    public void PlayHitSound()
    {
        PlaySound(hitSound);
    }

    public void PlayEnemyDeathSound()
    {
        PlaySound(deathEnemySound);
    }
    public void PlayDeathSound()
    {
        PlaySound(deathSound);
    }
    public void PlayJumpSound()
    {
        PlaySound(JumpSound);
    }

    private void PlaySound(AudioClip clip)
    {
        if (clip != null)
            audioSource.PlayOneShot(clip, _volume);
    }

    public void VolumeChange(float volume)
    {
        _volume = volume;
    }

}