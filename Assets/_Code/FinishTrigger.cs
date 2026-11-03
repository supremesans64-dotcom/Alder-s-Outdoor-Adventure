using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public GameObject endScreen;

    void Start()
    {
     endScreen.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Character"))
        {
         endScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
