using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scorekontrol : MonoBehaviour {

    public Text text;
    public AudioSource backscore;
	void Start () {
        backscore.volume = PlayerPrefs.GetFloat("volume");
        StartCoroutine(func());
	}
    IEnumerator func()
    {
        text.text = "Your Score: " + PlayerPrefs.GetInt("score");
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("mainMenu");

    }
}
