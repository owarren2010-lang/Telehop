using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Sound
{
    public string name;

    public AudioClip clip;

    [Range(0f,1f)]
    public float volume = 1f;

    [Range(1f, 3f)]
    public float pitch = 1f;

    public bool loop = false;

    [HideInInspector]
    public AudioSource source;
}

public class MusicManager : MonoBehaviour
{
        public static MusicManager Instance;

    public Sound[] sounds;

    [Header("Seperate Sources")]
    public AudioSource musicSource;
    public AudioSource sfxSource;

    private void Awake()
    {
        if(Instance == null)
        {
         Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
        Destroy(gameObject);
            return;
        }
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
    Sound s = System.Array.Find(sounds, sound => sound.name == name);
        if(s == null)
        {
        Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }
    public void Stop() 
    { 
    Sound s = System.Array.Find(sounds, sound => sound.name == name);
        if (s == null) return;

        s.source.Stop();
    }

        public void PlayMusic(AudioClip clip)
        {
        musicSource.clip = clip;
        musicSource.loop = true;
        musicSource.Play();
        }

        public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void SetMusicVolume(float volume)
    {
    musicSource.volume = volume;
    }

    public void SetSFXVolume(float volume)
    {
    sfxSource.volume = volume;
    }
}   
