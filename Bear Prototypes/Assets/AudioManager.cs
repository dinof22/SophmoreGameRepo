using UnityEngine.Audio;
using UnityEngine;
using System;


public class AudioManager : MonoBehaviour {

    public AudioMixerSnapshot MainTheme;
    public AudioMixerSnapshot ChaseTheme;
    public AudioMixerSnapshot TempleTheme;
    public AudioMixerSnapshot CaveTheme;
    public AudioMixerSnapshot SwampTheme;
    public AudioMixerSnapshot SilenceTheme;
    public AudioMixerSnapshot RelaxTheme;


    public Sound[] sounds;

    private void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    //private void Start()
    //{
     //   Play("ThemeSong");
   // }


}

/*Use this code to call an aoudio clip from another script:
 * 
 *     FindObjectOfType<AudioManager>().Play("GameSoudWhatever");
 *     
 *     transision to audio Mixer snapshots:
 *     FindObjectOfType<AudioManager>().WhateverSnapshotYouWant.TransitionTo(whateverTransitionTimeYouWantFloat);
 *     
 *     */
