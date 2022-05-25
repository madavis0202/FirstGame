using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public AudioSource birdSound;
    public Text buttonText;
    public Image buttonImage;
    //add inputfield inputtext

    // Start is called before the first frame update
    void Start()
    {
    }

    public void PlayBirdSound()
    {
        birdSound.Play();
    }

    public void KillButton()
    {
        buttonText.enabled = false;
        buttonImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
