using UnityEngine;
using UnityEngine.Rendering;

public class HatPickup : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip hatPickup;
    public Transform hatPoint;
    public float volume;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(hatPickup, volume);
    }
}
