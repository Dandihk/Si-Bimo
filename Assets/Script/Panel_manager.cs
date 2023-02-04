using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel_manager : MonoBehaviour
{
    
    public Button[] button_materi;
    public GameObject[] panel_materi;
    [Space]
    public Button[] button_setting;
    public GameObject[] panel_setting;

    public void btn_panel_materi(int btn_on)
    {
        for (int i = 0; i < button_materi.Length; i++)
        {
            button_materi[i].interactable = true;
            panel_materi[i].SetActive(false);
        }

        for (int i = 0; i <= btn_on; i++)
        {
            button_materi[btn_on].interactable = false;
            panel_materi[btn_on].SetActive(true);
        }

    }

    public void btn_panel_setting(int btn_on)
    {
        for (int i = 0; i < button_setting.Length; i++)
        {
            button_setting[i].interactable = true;
            panel_setting[i].SetActive(false);
        }

        for (int i = 0; i <= btn_on; i++)
        {
            button_setting[btn_on].interactable = false;
            panel_setting[btn_on].SetActive(true);
        }

    }

}
