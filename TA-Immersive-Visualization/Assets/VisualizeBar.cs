using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using TMPro;
using UnityEngine;
using UnityEditor;

public class VisualizeBar : MonoBehaviour
{
    private string db_url = "https://immersive-visualization-pemilu-default-rtdb.asia-southeast1.firebasedatabase.app/";
    public string candidateName;
    enum Province {
        total,
        aceh, 
        bali, 
        banten, 
        bengkulu, 
        dki_jakarta, 
        gorontalo,
        jambi,
        jawa_barat,
        jawa_tengah,
        jawa_timur,
        kalimantan_barat,
        kalimantan_selatan,
        kalimantan_tengah,
        kalimantan_timur,
        kalimantan_utara,
        kepulauan_bangka_belitung,
        kepulauan_riau,
        lampung,
        luar_negeri,
        maluku,
        maluku_utara,
        ntb,
        ntt,
        papua,
        papua_barat,
        riau,
        sulawesi_barat,
        sulawesi_selatan,
        sulawesi_tengah,
        sulawesi_tenggara,
        sulawesi_utara,
        sumatera_barat,
        sumatera_selatan,
        sumatera_utara,
        yogyakarta,
    }
    [SerializeField] 
    private Province province = new Province();
    public GameObject Bar;
    public TextMeshPro voterValue;
    private float barWidth = 1f;

    private float normalizeValue(int value){
        float newValue;
        if (((int)province) != 0){
            newValue = (float)value * 0.001f;
            return newValue;
        }
        else{
            newValue = (float)value * 0.00001f;
            return newValue;
        }
    }

    private void RetrieveData(){
        Candidate candidate = new Candidate(candidateName);
        RestClient.Get<Candidate>(db_url + candidate.name + ".json").Then(response => {
            candidate = response;
            adjustBar(candidate.getProvince((int)province));
            setTextValue(candidate.getProvince((int)province));

        });
    }

    private void adjustBar(int value){
        Bar.transform.localScale = new Vector3(barWidth, normalizeValue(value), barWidth);
    }

    private void setTextValue(int value){
        voterValue.text = value.ToString();
    }

    IEnumerator updateBar(){
        while (true){
            RetrieveData();
            yield return new WaitForSecondsRealtime(5);
        }
    }

    void Start() 
    {
        StartCoroutine(updateBar());
    }

}
