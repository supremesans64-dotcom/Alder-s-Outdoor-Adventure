using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
  public void LoadSpecificSceneByName(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);

    }

}
