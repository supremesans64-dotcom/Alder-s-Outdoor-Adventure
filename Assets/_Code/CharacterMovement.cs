using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class CharacterMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float jumpSpeed;
    private float ySpeed;
    private CharacterController controller;
    private bool isGrounded;
    public CoinManager cm;
    public Transform hatPoint;
    public HatManager hatManager;
    public GameObject endScreen;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent <CharacterController>();
        endScreen.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3 (horizontal, 0, vertical);
        moveDirection = Vector3.ClampMagnitude(moveDirection, 1f);
        // moveDirection.Normalize();
        // float magnitude = Mathf.Clamp(magnitude);
        // transform.Translate (moveDirection * speed * Time.deltaTime);
        Quaternion targetRotation;
        if (moveDirection == Vector3.zero)
        {
            targetRotation = transform.rotation;

        }

        else
        {
        targetRotation = Quaternion.LookRotation(moveDirection.normalized, Vector3.up);
        
        }
        transform.rotation = targetRotation;

        controller.SimpleMove(moveDirection * speed);


        ySpeed += Physics.gravity.y * Time.deltaTime;
        if (Input.GetButtonDown("Jump"))
        {
            ySpeed = -0.5f;
            isGrounded = false;
        }

        Vector3 vel = moveDirection * speed;
        vel.y = ySpeed;
        controller.Move(vel * Time.deltaTime);

        if (controller.isGrounded)
        {
            ySpeed = -0.5f;
            isGrounded = true;
            if (Input.GetButtonDown("Jump"))
            {

                ySpeed = jumpSpeed;
                isGrounded = false;
            }
        }


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            // other.GetComponent<CoinPickup>().pickedUp == false
            if (!other.GetComponent<CoinPickup>().pickedUp)
            {
                cm.coinCount += other.GetComponent<CoinPickup>().coinValue;
                other.GetComponent<CoinPickup>().ActivateCoin();
            }
        }

        if (other.gameObject.CompareTag("Kill Volume")) 
        { 
            SceneManager.LoadScene("GameScene");
        }

        if (other.gameObject.CompareTag("Hat"))
        {
            hatManager.EquipHat(other.gameObject);
            Debug.Log("Picked up hat");
        }

        if (other.gameObject.CompareTag("DealWithIt"))
        {
            hatManager.EquipHat(other.gameObject);
            Debug.Log("Picked up sunglasses");
        }

        if (other.gameObject.CompareTag("ExclamationMark"))
        {
            hatManager.EquipHat(other.gameObject);
            Debug.Log("Picked up exclamation mark");
        }

        if (other.gameObject.CompareTag("SillyHat"))
        {
            hatManager.EquipHat(other.gameObject);
            Debug.Log("Picked up silly hat");
        }

        if (other.gameObject.CompareTag("HockeyMask"))
        {
            hatManager.EquipHat(other.gameObject);
            Debug.Log("Picked up hockey mask");
        }

        if (other.gameObject.CompareTag("WaterBottle"))
        {
            hatManager.EquipHat(other.gameObject);
            Debug.Log("Picked up water bottle");
        }

        if (other.gameObject.CompareTag("FinishLine"))
        {
            endScreen.SetActive(true);
            Time.timeScale = 0f;
        }

        /*   if (other.gameObject.CompareTag("AlderHat"))
       {
           // transform.position = hatPoint.transform.position;
           other.transform.parent = this.transform;
       }

           if (other.gameObject.CompareTag("InfernBlueHair"))
       {
           // transform.position = hatPoint.transform.position;
           other.transform.parent = this.transform;
       }*/
    }
}
