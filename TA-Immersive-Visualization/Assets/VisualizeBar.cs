using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using TMPro;
using UnityEngine;
using UnityEditor;

public class VisualizeBar : MonoBehaviour
{
    public string db_url = "https://immersive-visualization-pemilu-default-rtdb.asia-southeast1.firebasedatabase.app/";
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
    private float barWidth = 0.5f;
    private float updateInterval = 0.001f;
    private float nextUpdateTime = 10f;

    private float normalizeValue(int value){
        float newValue = (float)value * 0.0001f;
        return newValue;
    }

    private void RetrieveData(){
        Candidate candidate = new Candidate(candidateName);
        RestClient.Get<Candidate>(db_url + candidate.name + ".json").Then(response => {
            candidate = response;
            adjustBar(candidate);
            setTextValue(candidate.getProvince((int)province));
        });
    }

    private void adjustBar(Candidate candidate){
        Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.getProvince((int)province)), barWidth);
    }

    private void setTextValue(int value){
        voterValue.text = value.ToString();
    }

    void Start()
    {
        
        RetrieveData();
    }

    void Update()
    {
        if(Time.time > nextUpdateTime){
            RetrieveData();
            nextUpdateTime = Time.time + updateInterval;
        }
    }
}
