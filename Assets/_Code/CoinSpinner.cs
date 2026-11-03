using UnityEngine;

public class CoinSpinner : MonoBehaviour
{

    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.World);


    }
}
