using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Audio_manager : MonoBehaviour
{

    public static Audio_manager Instance;
    public Sound[] BGM, SFX, Step;
    public AudioSource BGM_source, SFX_source, Step_source;

    public float BGM_vol,SFX_vol,Step_vol;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        BGM_vol = PlayerPrefs.GetFloat("BGM_vol");

        Play_BGM("BGM");

        SFX_vol = PlayerPrefs.GetFloat("SFX_vol");
        Step_vol = PlayerPrefs.GetFloat("Step_vol");
    }
    public void Play_BGM(string name)
    {
        Sound s = Array.Find(BGM, x => x.name == name);
        if (s == null)
        {
            Debug.Log("BGM_tidak_ada");
        }
        else
        {
            BGM_source.clip = s.clip;
            BGM_source.Play();
        }

    }

    public void Play_SFX(string name)
    {
        Sound s = Array.Find(SFX, x => x.name == name);
        if (s == null)
        {
            Debug.Log("SFX_tidak_ada");
        }
        else
        {
            SFX_source.PlayOneShot(s.clip);
        }

    }

    public void stop_SFX(string name) ////////////
    {
        Sound s = Array.Find(SFX, x => x.name == name);
        if (s == null)
        {
            Debug.Log("SFX_tidak_ada");
        }
        else
        {
            SFX_source.clip = s.clip;
            SFX_source.Stop();
        }

    }

    public void Play_Step(string name)
    {
        Sound s = Array.Find(Step, x => x.name == name);
        if (s == null)
        {
            Debug.Log("Step_tidak_ada");
        }
        else
        {
            Step_source.clip = s.clip;
            Step_source.Play();
        }

    }

    private void Update()
    {
        BGM_source.volume = BGM_vol;
        BGM_vol = PlayerPrefs.GetFloat("BGM_vol");

        SFX_source.volume = SFX_vol;
        SFX_vol = PlayerPrefs.GetFloat("SFX_vol");
        Step_source.volume = Step_vol;
        Step_vol = PlayerPrefs.GetFloat("Step_vol");
    }

    //public void BGM_volume(float volume)
    //{
    //    BGM_vol = volume;
    //}
    //public void SFX_volume(float volume)
    //{
    //    //float volume = PlayerPrefs.GetFloat("volume_sfx");
    //    SFX_source.volume = volume;
    //}
    //public void Step_volume(float volume)
    //{
    //    //float volume = PlayerPrefs.GetFloat("volume_step");
    //    Step_source.volume = volume;
    //}

    //public void Step_volume(float volume)
    //{
    //    Step_source.volume = volume;
    //}
}
