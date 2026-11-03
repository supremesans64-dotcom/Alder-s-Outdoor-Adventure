using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform respawnPoint;
    public Transform characterPosition;

    void OnTriggerEnter(Collider other)
    {
        // if (other.tag == "Character")
        //{
            characterPosition.transform.position = respawnPoint.transform.position;
         //   Rigidbody rb = other.GetComponent<Rigidbody>();
            Debug.Log("EnterTrigger");

           // if (rb != null) 
           // {
          //      rb.linearVelocity = Vector3.zero;
           //     rb.angularVelocity = Vector3.zero;
           // }
       // } 
    }
}
