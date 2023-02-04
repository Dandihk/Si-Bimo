using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume_control : MonoBehaviour
{
    public Slider BGM_slider, SFX_slider;


    private void Start()
    {


        BGM_slider.value = PlayerPrefs.GetFloat("BGM_vol",0.5f);
        SFX_slider.value = PlayerPrefs.GetFloat("SFX_vol",0.5f);
    }

    private void Update()
    {
        float BGM_vol = BGM_slider.value;
        PlayerPrefs.SetFloat("BGM_vol", BGM_vol);

        float SFX_vol = SFX_slider.value;
        PlayerPrefs.SetFloat("SFX_vol", SFX_vol);
        PlayerPrefs.SetFloat("Step_vol", SFX_vol);
    }

    public void value_slider_default()
    {
        BGM_slider.value = 0.5f;
        SFX_slider.value = 0.5f;
    }
    //public void BGM_vol()
    //{
    //    float vol_bgm = BGM_slider.value;
    //    PlayerPrefs.SetFloat("volume_bgm", vol_bgm);

    //    //Audio_manager.Instance.BGM_volume(PlayerPrefs.GetFloat("volume_bgm");


    //}

    //public void SFX_vol()
    //{
    //    //Audio_manager.Instance.SFX_volume(SFX_slider.value);
    //    PlayerPrefs.SetFloat("volume_sfx", SFX_slider.value);
    //}
    //public void Step_vol()
    //{
    //    //Audio_manager.Instance.Step_volume(SFX_slider.value);
    //    PlayerPrefs.SetFloat("volume_step", SFX_slider.value);
    //}
}
