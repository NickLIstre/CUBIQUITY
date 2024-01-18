using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().StopMusic();
    }

    private GameObject[] music;

    void Start()
    {
        music = GameObject.FindGameObjectsWithTag("gameMusic");
        Destroy(music[1]);
    }
}