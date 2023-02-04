using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using System;

public class Soal_manager_ingame : MonoBehaviour
{

    [Space]
    public SpriteRenderer img_soal;
    public SpriteRenderer[] img_jawaban;
    [SerializeField] int nomor_soal;
    [SerializeField] int game_round;
    public int[] random_jawaban;
    public int[] random_soal;
    [Space]
    public Control_soal control_Soal;

    [Space]
    public Player_manager Player_manager;

    public SpriteRenderer[] btnsoalingame;


    // Start is called before the first frame update
    void Start()
    {
        random_urutan_soal();
        tampil_soal();
    }

    // Update is called once per frame
    void Update()
    {

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
        Sprite currentjawaban = EventSystem.current.currentSelectedGameObject.gameObject.GetComponent<SpriteRenderer>().sprite;

        if (currentjawaban.name == control_Soal.Banyak_soal[random_soal[nomor_soal]].Elemen_Soal.gambar_jawaban[control_Soal.Banyak_soal[random_soal[nomor_soal]].Elemen_Soal.jawaban_benar].name)
        {
            Debug.Log("benar");
            Player_manager.banyak_darah++;


        }
        else
        {
            Debug.Log(currentjawaban.name);
            //Panel_hasil_salah_benar.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "salahh";
            Player_manager.banyak_darah--;



        }


    }
}

