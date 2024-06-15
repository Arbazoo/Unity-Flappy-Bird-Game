using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStart : MonoBehaviour
{
    public void PlayGame()
    {
        StartCoroutine(LoadGameAfterDelay());
    }

    private IEnumerator LoadGameAfterDelay()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadSceneAsync(1);
    }
}
