using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    public AudioSource SFX;
    public AudioClip button;
    public AudioClip cancelbutton;


    public void PlayButton()
    {
        SFX.clip = button;
        SFX.Play();
    }
    public void CreditButton()
    {
        SFX.clip = button;
        SFX.Play();
    }
    public void OptionButton()
    {
        SFX.clip = button;
        SFX.Play();
    }
    public void QuitButton()
    {
        SFX.clip = cancelbutton;
        SFX.Play();
    }
    public void CancelButton()
    {
        SFX.clip = cancelbutton;
        SFX.Play();
    }
    public void UrlButton()
    {
        SFX.clip = button;
        SFX.Play();
    }
}
