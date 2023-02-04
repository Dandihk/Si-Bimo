using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;


public class Menu_manager : MonoBehaviour
{

    [SerializeField] private GameObject panel_keluar;
    [SerializeField] private GameObject panel_level;
    [SerializeField] private GameObject panel_materi;
    [SerializeField] private GameObject panel_setting;
    [SerializeField] private GameObject panel_menu;
    [SerializeField] private GameObject panel_anim_bimo;
    [Space]
    [SerializeField] private GameObject panel_pecahan_biasa;
    [SerializeField] private GameObject panel_pecahan_campuran;
    [SerializeField] private GameObject panel_desimal;
    [SerializeField] private GameObject panel_persen;
    [Space]
    [SerializeField] private GameObject panel_setting_isi;
    [SerializeField] private GameObject panel_about;
    [Space]
    [Space]
    public float time_trans;
    [Space]
    public Animator anim_menu;
    public Animator anim_level;
    public Animator anim_exit;
    public Animator anim_materi;
    public Animator anim_setting;
    public Animator anim_bimo;
    [Space]
    [SerializeField] private Button pecahan_biasa_btn;
    [SerializeField] private Button pecahan_campuran_btn;
    [SerializeField] private Button desimal_btn;
    [SerializeField] private Button persen_btn;
    [Space]
    [SerializeField] private Button setting_btn;
    [SerializeField] private Button about_btn;



    private void Awake()
    {
        PlayerPrefs.SetInt("nilai", 0);
        PlayerPrefs.SetInt("peraturansudah", 0);
        PlayerPrefs.SetInt("berry_res", 0);
    }

    public void keluar()
    {
        panel_keluar.SetActive(true);
    }
    public void keluar_aplikasi()
    {
        Debug.Log("keluar");
        Application.Quit();
    }
    public void keluar_balik_menu()
    {
        StartCoroutine(exit_ke_menu());
    }

    IEnumerator exit_ke_menu()
    {
        anim_exit.SetTrigger("exit");
        yield return new WaitForSeconds(time_trans);
        panel_keluar.SetActive(false);
        
    }
    public void menu_level()
    {
        StartCoroutine(menu_ke_level());
    }
    IEnumerator menu_ke_level()
    {
        anim_menu.SetTrigger("menu");
        anim_bimo.SetTrigger("bimo_fade");
        yield return new WaitForSeconds(time_trans);
        panel_anim_bimo.SetActive(false);
        panel_menu.SetActive(false);
        panel_level.SetActive(true);
    }

    public void level_kembali()
    {
        
        StartCoroutine(level_ke_menu());
    }

    IEnumerator level_ke_menu()
    {
        anim_level.SetTrigger("level");
        
        yield return new WaitForSeconds(time_trans);
        panel_anim_bimo.SetActive(true);
        panel_menu.SetActive(true);
        panel_level.SetActive(false);
    }

    public void materi()
    {
        StartCoroutine(menu_ke_materi());
        
    }
    IEnumerator menu_ke_materi()
    {
        anim_menu.SetTrigger("menu");
        anim_bimo.SetTrigger("bimo_fade");
        yield return new WaitForSeconds(time_trans);
        panel_anim_bimo.SetActive(false);
        panel_menu.SetActive(false);
        panel_materi.SetActive(true);
    }
    public void materi_kembali()
    {
        StartCoroutine(materi_ke_menu());
    }

    IEnumerator materi_ke_menu()
    {
        anim_materi.SetTrigger("materi");
        yield return new WaitForSeconds(time_trans);
        panel_materi.SetActive(false);
        panel_anim_bimo.SetActive(true);
        panel_menu.SetActive(true);
    }

    public void setting()
    {
        StartCoroutine(menu_ke_setting());
        
    }
    IEnumerator menu_ke_setting()
    {
        anim_menu.SetTrigger("menu");
        anim_bimo.SetTrigger("bimo_fade");
        yield return new WaitForSeconds(time_trans);
        panel_anim_bimo.SetActive(false);
        panel_menu.SetActive(false);
        panel_setting.SetActive(true);
    }

    public void setting_kembali()
    {
        StartCoroutine(setting_ke_menu());
    }

    IEnumerator setting_ke_menu()
    {
        anim_setting.SetTrigger("setting");
        yield return new WaitForSeconds(time_trans);
        panel_anim_bimo.SetActive(true);
        panel_menu.SetActive(true);
        panel_setting.SetActive(false);
    }

}
