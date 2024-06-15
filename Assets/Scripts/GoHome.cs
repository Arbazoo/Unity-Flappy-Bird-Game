
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoHome : MonoBehaviour
{
    public void Home()
    {
        
        SceneManager.LoadScene(0);
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
        Time.timeScale = 1f;
        
    }
    private void OnSceneUnloaded(Scene unloadedScene)
    {
        // Check if the unloaded scene is the one where you want to stop DontDestroyOnLoad
        if (unloadedScene.name == "Flappy Bird")
        {
            // Destroy the GameManager instance
            Destroy(gameObject);
        }
    }
}


    