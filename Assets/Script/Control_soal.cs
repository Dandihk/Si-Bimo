using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_soal : MonoBehaviour
{
    public List<soal> Banyak_soal;
    [System.Serializable]
    public class soal
    {
        [System.Serializable]
        public class elemen_soal
        {
            public Sprite gambar_soal;
            public Sprite[] gambar_jawaban;
            public int jawaban_benar;
        }
        public elemen_soal Elemen_Soal;
    }

    
}
