using UnityEngine;

public class PauseControl : MonoBehaviour
{
    public static bool gameIsPaused;
    public OrbitalCamera orbitalCamera;
    public GameObject pauseScreen;
    public AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }  
    }

    public void TogglePause()
    {
        gameIsPaused = !gameIsPaused;
        PauseGame();
    }

    void PauseGame()
    {
        if (gameIsPaused) 
        {
            Time.timeScale = 0f;
            orbitalCamera.enabled = false;
            pauseScreen.SetActive(true);
            audioSource.Pause();
        }

        else
        {
            Time.timeScale = 1f;
            orbitalCamera.enabled = true;
            pauseScreen.SetActive(false);
            audioSource.UnPause();
        }
    }
}
