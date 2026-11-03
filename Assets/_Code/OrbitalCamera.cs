using UnityEngine;

public class OrbitalCamera : MonoBehaviour
{
    public Transform player;
    public float distance = 5f;
    public float orbitSpeed = 5f;
    private float currentX = 0f;
    private float currentY = 0f;

    // dsufweuh

    // Update is called once per frame
    void Update()
    {
        currentX += Input.GetAxis("Mouse X") * orbitSpeed;
        currentY -= Input.GetAxis("Mouse Y") * orbitSpeed;

        currentY = Mathf.Clamp(currentY, -80f, 80f);
    }

    void LateUpdate()
    {
        if (player != null)
        { 
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        Vector3 position = player.position - (rotation * Vector3.forward * distance);
        transform.rotation = rotation;
        transform.position = position;
        }
    }
}
