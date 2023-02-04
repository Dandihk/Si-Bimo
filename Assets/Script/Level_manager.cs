using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_manager : MonoBehaviour
{
    int level_buka;
    public Button[] buttons;
    int nilai_lock_level;
    public GameObject[] gembok_level;
    
    void Start()
    {
        tambah_level();
        Debug.Log(PlayerPrefs.GetInt("level_buka"));
        Debug.Log(PlayerPrefs.GetInt("nilai_lock_level"));
    }

    public void tambah_level()
    {
        level_buka = PlayerPrefs.GetInt("level_buka", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < level_buka; i++)
        {
            buttons[i].interactable = true;
        }
        

        nilai_lock_level = PlayerPrefs.GetInt("nilai_lock_level", 1);
        for (int i = 0; i < gembok_level.Length; i++)
        {
            gembok_level[i].SetActive(true);
        }
        for (int i = 0; i < nilai_lock_level; i++)
        {
            gembok_level[i].SetActive(false);
        }
        
    }
}
