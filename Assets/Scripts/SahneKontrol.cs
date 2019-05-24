using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SahneKontrol : MonoBehaviour {
    public Slider slider;
    public AudioSource backgroundmainmenu;
    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volume");
    }
    private void Update()
    {
        backgroundmainmenu.volume = PlayerPrefs.GetFloat("volume");
    }
    public void Play()
    {       
        SceneManager.LoadScene("gameScene");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void volumechanged()
    {
        PlayerPrefs.SetFloat("volume", slider.value);
    }
}
