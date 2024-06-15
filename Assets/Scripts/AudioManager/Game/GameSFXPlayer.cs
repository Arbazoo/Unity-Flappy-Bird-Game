using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSFXPlayer : MonoBehaviour
{
    public AudioSource SFX;
    public AudioClip homebutton;
    public AudioClip button;

    public void HomeButton()
    {
        SFX.clip = homebutton;
        SFX.Play();
    }
    public void PlaySymbol()
    {
        SFX.clip = button;
        SFX.Play();
    }

}
