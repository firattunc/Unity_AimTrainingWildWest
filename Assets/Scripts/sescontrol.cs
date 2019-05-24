using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sescontrol : MonoBehaviour {

    AudioSource audio;
    void Start () {
        audio = GetComponent<AudioSource>();
    }
	
	void Update () {
        audio.volume -=0.0020f;
	}
}
