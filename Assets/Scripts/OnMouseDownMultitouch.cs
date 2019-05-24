using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDownMultitouch : MonoBehaviour
{
    GameObject gameObject;
    AudioSource audio;
    GameObject oyunkontrol;
    oyunkontrol kontrol;
    

    void Start()
    {
        audio = GetComponent<AudioSource>();
        gameObject = GameObject.FindGameObjectWithTag("target");
        oyunkontrol = GameObject.FindGameObjectWithTag("oyunkontrol");
        kontrol = oyunkontrol.GetComponent<oyunkontrol>();

    }
    void Update()
    {
        
        Camera camera = Camera.main;
        RaycastHit hit;

        if (camera == null)
            return;

        for ( int i = 0; i < Input.touchCount; i++ )
        {
            Touch parmak = Input.GetTouch( i );
            if( parmak.phase == TouchPhase.Began )
            {
                audio.Play();
                gameObject = GameObject.FindGameObjectWithTag("target");
                if ( Physics.Raycast( camera.ScreenPointToRay( parmak.position ), out hit ) )
                {
                    kontrol.ScoreUp(10);
                    Destroy(gameObject);                   
                }
                    
            }
        }

    }
}