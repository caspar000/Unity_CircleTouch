using UnityEngine.Audio;
using System;
using UnityEngine;


public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;

    public Sound[] sounds;
    private float globalVolume = 0.5f;

    void Awake()
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name, float volume = 1f, float pitch = 1f)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        s.source.volume = volume;
        s.source.pitch = pitch;
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        s.source.Stop();
    }

    public void ChangeVolume(string name, float value)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.volume = value;
        s.source.volume = value;
    }

    // private void Update(){
    //     foreach (Sound s in sounds)
    //     {
    //         s.source.volume = globalVolume;
    //     }
    // }
}
