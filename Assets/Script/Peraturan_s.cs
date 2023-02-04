using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peraturan_s : MonoBehaviour
{

    public Animator anim_resume;
    public GameObject panel_peraturan;
    public GameObject panel1;
    public GameObject panel2;


    private void Start()
    {
        if (PlayerPrefs.GetFloat("peraturansudah") == 1)
        {
            panel_peraturan.SetActive(false);
        }
    }

    public void peraturan_ada()
    {
        PlayerPrefs.SetFloat("peraturansudah", 0);
    }

    public void tutup_peraturan()
    {
        StartCoroutine(peraturan());
        PlayerPrefs.SetFloat("peraturansudah",1);
    }

    IEnumerator peraturan()
    {
        anim_resume.SetTrigger("balik_main");
        yield return new WaitForSeconds(1);
        panel_peraturan.SetActive(false);
    }

    public void muncul_panel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }


}
