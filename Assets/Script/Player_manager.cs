using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_manager : MonoBehaviour
{
    public static int banyak_berry = 0;
    public static int banyak_berry_convert_nyawa = 0;//
    public static int banyak_darah = 5;
    public TextMeshProUGUI berry_text, darah_txt, berry_result_txt, nilai_result_txt;
    public GameObject panel_game_over;
    public GameObject panel_game_pause;
    public GameObject panel_game_setting;
    public GameObject panel_peraturan;
    public GameObject bimo_player;
    public Button naik_level;
    public Animator anim_resume;
    public Animator anim_panel_game_setting;
    public float time_tutup_menu;

    public static int nilai_result;

    int level_ini;
    int nilai_lock_level;


    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 1;
        Physics2D.IgnoreLayerCollision(6, 7, false); //// memaksa aktif jika corutine sakit terpotong

        //level_akhir();
        
    }
    private void Awake()
    {

        banyak_berry = 0;
        banyak_berry_convert_nyawa = 0;//
        banyak_darah = 15;
        nilai_result = 0;
    }

    

    // Update is called once per frame
    void Update()
    {
        berry_text.text = banyak_berry_convert_nyawa.ToString();////
        darah_txt.text = banyak_darah.ToString();
        //berry_result_txt.text = banyak_berry.ToString();
        berry_result_txt.text = PlayerPrefs.GetInt("berry_res", banyak_berry).ToString();
        
        //game_over();
        if (banyak_darah <= 0) ////////////////
        {
            game_over();
        }

        nilai();

        if(banyak_berry_convert_nyawa >= 20) ///
        {
            banyak_darah++;
            banyak_berry_convert_nyawa -= 20;
        }

        //Debug.Log(banyak_berry_convert_nyawa);
    }

    public void reset_berry()
    {
        PlayerPrefs.SetInt("berry_res", 0);
    }
    public void reset_nilai()
    {
        PlayerPrefs.SetInt("nilai", 0);
    }
    public void nilai()
    {
        level_ini = SceneManager.GetActiveScene().buildIndex;

        if (PlayerPrefs.GetInt("nilai", Player_manager.nilai_result) >= 14)
        {
            nilai_result_txt.text = "A";
            
            if (level_ini < 3)
            {
                naik_level.interactable = true;
            }
            else
            {
                naik_level.interactable = false;
            }
            
            buka_level();
        }
        else if (PlayerPrefs.GetInt("nilai", Player_manager.nilai_result) >= 12)
        {
            nilai_result_txt.text = "B+";
            if (level_ini < 3)
            {
                naik_level.interactable = true;
            }
            else
            {
                naik_level.interactable = false;
            }
            buka_level();
        }
        else if (PlayerPrefs.GetInt("nilai", Player_manager.nilai_result) >= 10)
        {
            nilai_result_txt.text = "B";
            if (level_ini < 3)
            {
                naik_level.interactable = true;
            }
            else
            {
                naik_level.interactable = false;
            }
            buka_level();
        }
        else if (PlayerPrefs.GetInt("nilai", Player_manager.nilai_result) >= 5)
        {
            nilai_result_txt.text = "C";
            if (level_ini < 3)
            {
                naik_level.interactable = true;
            }
            else
            {
                naik_level.interactable = false;
            }
            buka_level();
        }
        else if (PlayerPrefs.GetInt("nilai", Player_manager.nilai_result) <= 4)
        {
            nilai_result_txt.text = "D";
            naik_level.interactable = false;
            
        }

    }

    //public void nilai()
    //{
    //    level_ini = SceneManager.GetActiveScene().buildIndex;

    //    if (nilai_result >= 14)
    //    {
    //        nilai_result_txt.text = "A";

    //        if (level_ini < 3)
    //        {
    //            naik_level.interactable = true;
    //        }
    //        else
    //        {
    //            naik_level.interactable = false;
    //        }

    //        buka_level();
    //    }
    //    else if (nilai_result >= 12)
    //    {
    //        nilai_result_txt.text = "B+";
    //        if (level_ini < 3)
    //        {
    //            naik_level.interactable = true;
    //        }
    //        else
    //        {
    //            naik_level.interactable = false;
    //        }
    //        buka_level();
    //    }
    //    else if (nilai_result >= 10)
    //    {
    //        nilai_result_txt.text = "B";
    //        if (level_ini < 3)
    //        {
    //            naik_level.interactable = true;
    //        }
    //        else
    //        {
    //            naik_level.interactable = false;
    //        }
    //        buka_level();
    //    }
    //    else if (nilai_result >= 5)
    //    {
    //        nilai_result_txt.text = "C";
    //        if (level_ini < 3)
    //        {
    //            naik_level.interactable = true;
    //        }
    //        else
    //        {
    //            naik_level.interactable = false;
    //        }
    //        buka_level();
    //    }
    //    else if (nilai_result <= 4)
    //    {
    //        nilai_result_txt.text = "D";
    //        naik_level.interactable = false;

    //    }

    //}
    public void buka_level() // taruh di nilai
    {
        level_ini = SceneManager.GetActiveScene().buildIndex;
        if (level_ini >= PlayerPrefs.GetInt("level_buka"))
        {
            if (level_ini == 3)
            {
                PlayerPrefs.SetInt("level_buka", level_ini);
            }
            else
            {
                PlayerPrefs.SetInt("level_buka", level_ini + 1);
            } 

        }

        nilai_lock_level = SceneManager.GetActiveScene().buildIndex;
        if (nilai_lock_level >= PlayerPrefs.GetInt("nilai_lock_level"))
        {
            
            if(nilai_lock_level == 3)
            {
                PlayerPrefs.SetInt("nilai_lock_level", nilai_lock_level);
            }
            else
            {
                PlayerPrefs.SetInt("nilai_lock_level", nilai_lock_level + 1);
            }
        }

    }

    public void level_akhir()// untuk level 3 tok
    {
        level_ini = SceneManager.GetActiveScene().buildIndex;
        if (level_ini == 3)
        {
            naik_level.gameObject.SetActive(false);
        }
    }


    public void game_over()
    {
        panel_game_over.SetActive(true);
        StopAllCoroutines();
        Destroy(GameObject.FindWithTag("Player"));
        //if (banyak_darah == 0)
        //{
        //    //StartCoroutine(over());

        //    //Time.timeScale = 0;
        //}

    }
    public void game_pause()
    {
        panel_game_pause.SetActive(true);
        //bimo_player.SetActive(false);
        //StopAllCoroutines();
        //GameObject.FindGameObjectWithTag("Player").SetActive(false);
        Time.timeScale = 0;
    }
    public void game_resume()
    {
        //GameObject.FindGameObjectWithTag("Player").SetActive(true);
        //bimo_player.SetActive(true);
        StartCoroutine(resume());
        
        Time.timeScale = 1;
    }

    public void game_setting_ingame()
    {
        panel_game_setting.SetActive(true);
        panel_game_setting.transform.GetComponent<GraphicRaycaster>().enabled = true;
    }

    public void tutup_game_setting_ingame()
    {
        panel_game_setting.transform.GetComponent<GraphicRaycaster>().enabled = false;
        StartCoroutine(setting_ke_pause_ingame());
        
    }
    

    IEnumerator setting_ke_pause_ingame()
    {
        anim_panel_game_setting.SetTrigger("setting");
        yield return new WaitForSecondsRealtime(1f);
        panel_game_setting.SetActive(false);
        
    }


    IEnumerator resume()
    {
        anim_resume.SetTrigger("balik_main");
        yield return new WaitForSeconds(1);
        panel_game_pause.SetActive(false);
    }


}
