using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using System;

public class Soal_manager : MonoBehaviour
{
    [Space]
    public GameObject pop_soal;
    //public GameObject npc;
    [Space]
    public Image img_soal;
    public Image[] img_jawaban;
    [SerializeField] int nomor_soal;
    [SerializeField] int game_round;
    public int[] random_jawaban;
    public int[] random_soal;
    [Space]
    public TextMeshProUGUI game_nomor_soal_txt;
    public TextMeshProUGUI game_round_txt;
    [Space]
    public Control_soal control_Soal;
    public GameObject Panel_hasil_benar;
    public GameObject Panel_hasil_salah;
    public GameObject Panel_hasil_seluruh;
    [Space]
    public TextMeshProUGUI darah_text_soal;
    [Space]
    public float default_waktu_soal;
    public float waktu_soal;
    public TextMeshProUGUI text_waktu;
    bool is_start_waktu;
    [Space]
    public Player_manager Player_manager;
    public int time_anim_salah_benar;
    [Space]
    public Animator anim_soal;
    public Animator anim_pintu;
    [Space]
    public GameObject pintu;



    // Start is called before the first frame update
    void Start()
    {
        //random_urutan_soal();
        //tampil_soal();
        //start_waktu();

    }


    public void mulai()
    {
        random_urutan_soal();
        tampil_soal();
        start_waktu();

        

        game_round_txt.text = game_round.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        darah_text_soal.text = Player_manager.banyak_darah.ToString();

        //if (Player_manager.banyak_darah == 0)
        //{
        //    pop_soal.SetActive(false);
        //    Panel_hasil_salah_benar.SetActive(false);
        //}
        
        game_nomor_soal_txt.text = (nomor_soal+1).ToString();

        if (nomor_soal==game_round)
        {
            anim_pintu.SetTrigger("pintu_out");
            pintu.transform.GetComponent<BoxCollider2D>().enabled = false;
        }

        

    }

 


    void random_urutan_jawaban()
    {
        for (int i = 0; i < random_jawaban.Length; i++)
        {
            int a = random_jawaban[i];
            int b = UnityEngine.Random.Range(0, random_jawaban.Length);
            random_jawaban[i] = random_jawaban[b];
            random_jawaban[b] = a;
        }
    }

    void random_urutan_soal()
    {
        for (int i = 0; i < random_soal.Length; i++)
        {
            int a = random_soal[i];
            int b = UnityEngine.Random.Range(0, random_soal.Length);
            random_soal[i] = random_soal[b];
            random_soal[b] = a;
        }
    }
    void tampil_soal()
    {
        

        random_urutan_jawaban();

        img_soal.sprite = control_Soal.Banyak_soal[random_soal[nomor_soal]].Elemen_Soal.gambar_soal;

        for (int i = 0; i < img_jawaban.Length; i++)
        {
            img_jawaban[i].sprite = control_Soal.Banyak_soal[random_soal[nomor_soal]].Elemen_Soal.gambar_jawaban[random_jawaban[i]];
        }

    }
    public void Button_jawaban()
    {
        Sprite currentjawaban = EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Image>().sprite;

        if (currentjawaban.name == control_Soal.Banyak_soal[random_soal[nomor_soal]].Elemen_Soal.gambar_jawaban[control_Soal.Banyak_soal[random_soal[nomor_soal]].Elemen_Soal.jawaban_benar].name)
        {
            Debug.Log("benar");
            Player_manager.banyak_darah++;
            Player_manager.nilai_result++;

            PlayerPrefs.SetInt("nilai", Player_manager.nilai_result);
            
            //Panel_hasil_salah_benar.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "benar";
            StartCoroutine(panel_benar());


        }
        else
        {
            Debug.Log("salah");
            //Panel_hasil_salah_benar.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "salahh";
            Player_manager.banyak_darah--;
            
            StartCoroutine(panel_salah());



        }
        //Panel_hasil_salah_benar.SetActive(true);

    }

    public void button_reset()// dipake akhir/ pake game over aja
    {
        pop_soal.SetActive(false);
        Panel_hasil_seluruh.SetActive(false);
    }

    IEnumerator panel_benar()
    {
        is_start_waktu = false;///////////

        Panel_hasil_benar.SetActive(true);
        yield return new WaitForSeconds(time_anim_salah_benar);

        Panel_hasil_benar.SetActive(false);
        
        nomor_soal++;
        

        Debug.Log(nomor_soal);
        if (nomor_soal < game_round)
        {
            tampil_soal();
            is_start_waktu = true;///////////
            start_waktu();/////////
        }
        else ///////////
        {
            pop_soal.transform.GetComponent<GraphicRaycaster>().enabled = false; ///////////////////
            anim_soal.SetTrigger("soal_out");
            
            yield return new WaitForSeconds(2);
            pop_soal.SetActive(false);
            is_start_waktu = false;///
        }
        //if (nomor_soal == game_round)
        //{
        //    anim_soal.SetTrigger("soal_out");
        //    yield return new WaitForSeconds(2);
        //    pop_soal.SetActive(false);
        //    //Panel_hasil_seluruh.SetActive(false);
        //}
        //else
        //{
        //    tampil_soal();
        //}
    }

    IEnumerator panel_salah()
    {
        is_start_waktu = false;///////////

        Panel_hasil_salah.SetActive(true);
        yield return new WaitForSeconds(time_anim_salah_benar);

        Panel_hasil_salah.SetActive(false);
        nomor_soal++;

        
        Debug.Log(nomor_soal);
        if (nomor_soal < game_round)
        {
            tampil_soal();
            is_start_waktu = true;///////////
            start_waktu();////////
        }
        else ///////////
        {
            pop_soal.transform.GetComponent<GraphicRaycaster>().enabled = false; //////////////////////
            anim_soal.SetTrigger("soal_out");
            yield return new WaitForSeconds(2);
            pop_soal.SetActive(false);
            is_start_waktu = false;//
        }

        //if (nomor_soal == game_round)
        //{
        //    anim_soal.SetTrigger("soal_out");
        //    yield return new WaitForSeconds(2);
        //    pop_soal.SetActive(false);                   /////////////////////
        //    //Panel_hasil_seluruh.SetActive(false);
        //}
        //else
        //{
        //    tampil_soal();
        //}
    }

    void waktu_habis_gameround_masih()
    {
        nomor_soal++;
        tampil_soal();
        is_start_waktu = true;///////////
        start_waktu();////////

        //random_urutan_soal();
        //tampil_soal();
        //nomor_soal++;
        ////is_start_waktu = true;///////////
        //start_waktu();
    }

    void start_waktu()
    {
        waktu_soal = default_waktu_soal;/////////

        is_start_waktu = true;
        StartCoroutine(Start_waktu_soal());
    }

    IEnumerator Start_waktu_soal()
    {
        while (is_start_waktu == true)
        {
            waktu_soal -= Time.deltaTime;
            text_waktu.text = TimeSpan.FromSeconds(waktu_soal).ToString("mm':'ss");

            if (nomor_soal == game_round)
            {
                pop_soal.transform.GetComponent<GraphicRaycaster>().enabled = false; /////////////////////
                anim_soal.SetTrigger("soal_out");
                yield return new WaitForSeconds(2);
                pop_soal.SetActive(false);

                //Player_manager.game_over(); // buat uas pak guru di akhir level tok

                is_start_waktu = false;
            }

            else if (waktu_soal <= 0)
            {
                is_start_waktu = false;
                waktu_soal = 0;

                if (nomor_soal < game_round)
                {
                    waktu_habis_gameround_masih();
                    //random_urutan_soal();
                    //tampil_soal();
                    //nomor_soal++;
                    //is_start_waktu = true;///////////
                    //start_waktu();

                }
                else
                {
                    pop_soal.transform.GetComponent<GraphicRaycaster>().enabled = false; /////////////////////
                    anim_soal.SetTrigger("soal_out");
                    yield return new WaitForSeconds(2);
                    pop_soal.SetActive(false);
                    //Player_manager.game_over(); // buat uas pak guru di akhir level tok

                    anim_pintu.SetTrigger("pintu_out");
                    pintu.transform.GetComponent<BoxCollider2D>().enabled = false;

                    is_start_waktu = false;
                }

            }

            else if (Player_manager.banyak_darah <= 0)
            {
                pop_soal.transform.GetComponent<GraphicRaycaster>().enabled = false; /////////////////////
                anim_soal.SetTrigger("soal_out");
                yield return new WaitForSeconds(2);
                pop_soal.SetActive(false);
                //Player_manager.game_over(); // buat uas pak guru di akhir level tok

                is_start_waktu = false;
            }

            yield return null;

        }

    }
   
}
