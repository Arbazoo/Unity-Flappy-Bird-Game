using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void Quitgame()
    {
        StartCoroutine(QuitWithDelay());
    }

    private IEnumerator QuitWithDelay()
    {
        yield return new WaitForSeconds(0.5f);
        Application.Quit();
    }
}
