using UnityEngine;

public class PlatformCollision : MonoBehaviour
{
    // [SerializeField] string playerTag = "Character";
    // public GameObject player;

    void Start()
    {
     //   player = GameObject.FindWithTag("Character");
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Character"))
        {
            Debug.Log("Character in Trigger");
            other.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Character"))
        {
            other.transform.SetParent(null);
        }
    }

}
