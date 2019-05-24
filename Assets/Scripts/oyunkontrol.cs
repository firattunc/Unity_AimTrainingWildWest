using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class oyunkontrol : MonoBehaviour {

    public GameObject hedef;
    GameObject gobject;
    public GameObject player;  
    public Vector3 randomPos;
    int score=0;
    float sure = 30.0f;
    public Text text;
    public Text text1;
    public AudioSource backplay;
    void Start()
    {        
        Olustur();
        text.text = "Score: " + score;
        
    }
    void Update()
    {

        backplay.volume = PlayerPrefs.GetFloat("volume");
        if (player.transform.position.z > new Vector3(0.0f, 0.4f, 3.1f).z)
        {
            sure -= Time.deltaTime;
            text1.text = "Time: "+(int)sure;
            if (sure<0)
            {
                SceneManager.LoadScene("score");
                PlayerPrefs.SetInt("score", score);
                
            }
            gobject = GameObject.FindWithTag("target");
            if (gobject == null)
            {
                Olustur();
            }
        }
        else
        {
            player.transform.Translate(0, 0, 0.01f);
            Destroy(gobject);
        }
        

    }
    void Olustur()
    {
        Vector3 vec = new Vector3(Random.Range(randomPos.x, -randomPos.x), 0, Random.Range(2, randomPos.z));
        Instantiate(hedef, vec, Quaternion.identity);
        gobject = GameObject.FindGameObjectWithTag("target");
        gobject.transform.Rotate(90, 0, 0);
    }
    public void ScoreUp(int gelenScore)
    {       
        score += gelenScore;
        text.text = "Score: " + score;
    }


}
