using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public GameObject playerCapsule;
    public Material newMaterial;
    public static Material savedCapsuleMaterial;
    public GameObject rightEye;
    public GameObject leftEye;
    public Material newEyeColor;
    public static Material savedEyeMaterial;


    public void ChangeMaterial() 
    {
    if (playerCapsule != null && newMaterial != null) 
        {
        Renderer rend = playerCapsule.GetComponent<Renderer>();
        Renderer rightEyeRend = rightEye.GetComponent<Renderer>();
        Renderer leftEyeRend = leftEye.GetComponent<Renderer>();

            if (rend != null) 
            {
             rend.sharedMaterial = newMaterial;
             savedCapsuleMaterial = newMaterial;
             rightEyeRend.sharedMaterial = newEyeColor;
             leftEyeRend.sharedMaterial = newEyeColor;
             savedEyeMaterial = newEyeColor;
            }
        }
    }
}
