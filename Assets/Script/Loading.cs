using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public Animator loading_trans_in;
    public float time_trans;
    int level_ini;

    public void loadscene(int sceneid)
    {
        StartCoroutine(loadScene_anim(sceneid));
    }
    IEnumerator loadScene_anim(int sceneid)
    {
        Time.timeScale = 1;
        loading_trans_in.SetTrigger("in_loading");
        yield return new WaitForSeconds(time_trans);
        SceneManager.LoadScene(sceneid);

    }
    public void loadscene_naik_level()
    {
        StartCoroutine(loadScene_anim2());
    }
    IEnumerator loadScene_anim2()
    {
        Time.timeScale = 1;
        loading_trans_in.SetTrigger("in_loading");
        yield return new WaitForSeconds(time_trans);
        level_ini = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(level_ini + 1);
    }
    public void loadscene_restart()
    {
        StartCoroutine(loadScene_anim3());
    }
    IEnumerator loadScene_anim3()
    {
        Time.timeScale = 1;
        loading_trans_in.SetTrigger("in_loading");
        yield return new WaitForSeconds(time_trans);
        level_ini = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(level_ini);
    }
}

