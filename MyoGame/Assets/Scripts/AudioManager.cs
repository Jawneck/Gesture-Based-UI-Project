﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public static AudioManager audioManager = null;
    public AudioClip laserBlast;
    public AudioClip splashScreen;
    public AudioClip powerUp;

    private AudioSource soundEffect;

    // Use this for initialization
    void Start () {
		if(audioManager == null){

            audioManager = this;
        }else if(audioManager != this){

            Destroy(gameObject);
        }
        AudioSource source = GetComponent<AudioSource>();
        soundEffect = source;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}