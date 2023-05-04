using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoDetail : MonoBehaviour
{
    public GameObject JudulPontianak, CubePontianak, JudulJakarta, CubeJakarta, JudulSurabaya, CubeSurabaya, JudulYogyakarta, CubeYogyakarta;

    public bool show = false;

    public void ShowHideInfo()
    {
        if(!show)
        {
            JudulPontianak.SetActive(true);
            CubePontianak.SetActive(true);
            JudulJakarta.SetActive(true);
            CubeJakarta.SetActive(true);
            JudulSurabaya.SetActive(true);
            CubeSurabaya.SetActive(true);
            JudulYogyakarta.SetActive(true);
            CubeYogyakarta.SetActive(true);
            Debug.Log("true aktif");
            show = true;
        }
        else
        {
            JudulPontianak.SetActive(false);
            CubePontianak.SetActive(false);
            JudulJakarta.SetActive(false);
            CubeJakarta.SetActive(false);
            JudulSurabaya.SetActive(false);
            CubeSurabaya.SetActive(false);
            JudulYogyakarta.SetActive(false);
            CubeYogyakarta.SetActive(false);
            Debug.Log("false aktif");
            show = false;
        }
    }
}