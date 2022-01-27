using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    // Start is called before the first frame updatepublic class AudioPlayerManager: MonoBehaviour

    private static BGM instance = null;
    private AudioSource song;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        if (instance == this) return;
        Destroy(gameObject);
    }

    void Start()
    {
        PlayNewSong();
    }

    public virtual void PlayNewSong()
    {
        song = GetComponent<AudioSource>();
        if (!song.isPlaying)
        {
            song.Play();
        }
    }
}