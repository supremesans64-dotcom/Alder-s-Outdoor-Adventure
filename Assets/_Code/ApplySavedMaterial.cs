using UnityEngine;

public class ApplySavedMaterial : MonoBehaviour

{
    public GameObject player;
    public GameObject rightEye;
    public GameObject leftEye;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (MaterialChanger.savedCapsuleMaterial != null)
        {
            Renderer rend = player.GetComponent<Renderer>();
            Renderer rightEyeRend = rightEye.GetComponent<Renderer>();
            Renderer leftEyeRend = leftEye.GetComponent<Renderer>();

            if (rend != null)
            {
                rend.material = MaterialChanger.savedCapsuleMaterial;
            }

            if (rightEyeRend != null)
            {
                rightEyeRend.material = MaterialChanger.savedEyeMaterial;
            }

            if (leftEyeRend != null)
            {
                leftEyeRend.material = MaterialChanger.savedEyeMaterial;
            }
        }

        if (BlackMaterialChanger.savedCapsuleMaterial != null)
        {
            Renderer rend = player.GetComponent<Renderer>();
            Renderer rightEyeRend = rightEye.GetComponent<Renderer>();
            Renderer leftEyeRend = leftEye.GetComponent<Renderer>();

            if (rend != null)
            {
                rend.material = BlackMaterialChanger.savedCapsuleMaterial;
            }

            if (rightEyeRend != null)
            {
                rightEyeRend.material = BlackMaterialChanger.savedEyeMaterial;
            }

            if (leftEyeRend != null)
            {
                leftEyeRend.material = BlackMaterialChanger.savedEyeMaterial;
            }
        }
    }
}