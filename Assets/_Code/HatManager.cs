using UnityEngine;
using System.Collections.Generic;

public class HatManager : MonoBehaviour
{
    public Transform defaultPoint;
    public Transform defaultDropPoint;
    private GameObject currentHat;
    public Transform sunglassesPoint;
    public Transform sunglassesDropPoint;
    public Transform hockeyPoint;
    public Transform hockeyDropPoint;
    public Transform exclamationPoint;
    public Transform exclamationDropPoint;
    public Transform waterPoint;
    public Transform waterDropPoint;
    public Transform sillyDropPoint;
    private Transform currentDropPoint;

    /* void OnTriggerEnter (Collider other) 
    { 
    if (other.CompareTag("Hat")) 
        {
            EquipHat(other.gameObject);
        }
    } */

    public void EquipHat(GameObject newHat)
    {
        // If the player is already wearing a hat, we will drop it. This will be an if condition using our function UnequipHat.
        if (currentHat != null)
        {
            UnequipHat();
        }

        if (newHat.CompareTag("DealWithIt"))
        {
            newHat.transform.SetParent(sunglassesPoint, false);
            currentDropPoint = sunglassesDropPoint;
            Debug.Log("Picking up hat: " + newHat.name);
        }

        else if (newHat.CompareTag("ExclamationMark"))
        {
            newHat.transform.SetParent(exclamationPoint, false);
            currentDropPoint = exclamationDropPoint;
        }

        else if (newHat.CompareTag("SillyHat"))
        {
            newHat.transform.SetParent(sunglassesPoint, false);
            currentDropPoint = sillyDropPoint;
        }

        else if (newHat.CompareTag("HockeyMask"))
        {
            newHat.transform.SetParent(hockeyPoint, false);
            currentDropPoint = hockeyDropPoint;
        }

        else if (newHat.CompareTag("WaterBottle"))
        {
            newHat.transform.SetParent(waterPoint, false);
            currentDropPoint = waterDropPoint;
        }

        else
        {
            newHat.transform.SetParent(defaultPoint, false);
            currentDropPoint = defaultDropPoint;
        }

        // parent new Hat
        currentHat = newHat;

        // snap into place
        currentHat.transform.localPosition = Vector3.zero;
        currentHat.transform.localRotation = Quaternion.identity;

        // disable collider so it doesn't retrigger immediately
        Collider hatCollider = currentHat.GetComponent<Collider>();
        if (hatCollider != null)

        {
            hatCollider.enabled = false;
        }
    }

    public void UnequipHat()
    {
        Debug.Log("Dropping hat: " + currentHat.name + " at drop point: " + currentDropPoint.name);
        currentHat.transform.SetParent(null);
        currentHat.transform.localPosition = currentDropPoint.position;
        currentHat.transform.localRotation = currentDropPoint.rotation;

        //re-enable physics
        Collider hatCollider = currentHat.GetComponent<Collider>();
        if (hatCollider != null)

        {
            hatCollider.enabled = true;
        }

        

        currentHat = null;

    }
}
