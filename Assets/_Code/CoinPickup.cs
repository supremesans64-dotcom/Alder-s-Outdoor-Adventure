using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundEffect;
    public float volume = 1.0f;
    public int coinValue = 1;
    public bool pickedUp = false;

    void Start()
    {
        if (audioSource == null) 
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public int Value
    {
        get { return coinValue; } 
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    pickedUp = true;
    //    Destroy(gameObject);
    //    audioSource.PlayOneShot(soundEffect, volume);
    //}

    public void ActivateCoin()
    {
        pickedUp = true;
        audioSource.PlayOneShot(soundEffect, volume);
        Destroy(gameObject);
    }

}
