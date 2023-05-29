using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;
using UnityEditor;

public class VisualizeBar : MonoBehaviour
{
    public string db_url = "https://immersive-visualization-pemilu-default-rtdb.asia-southeast1.firebasedatabase.app/";
    public string candidateName;
    enum Province {
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
        total
    }
    [SerializeField] 
    private Province province = new Province();
    public GameObject Bar;
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
            Province child = Province.total;
            switch(child){
                case Province.aceh:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.aceh), barWidth);
                    break;
                case Province.bali:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.bali), barWidth);
                    break;
                case Province.banten:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.banten), barWidth);
                    break;
                case Province.bengkulu:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.bengkulu), barWidth);
                    break;
                case Province.dki_jakarta:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.dki_jakarta), barWidth);
                    break;
                case Province.gorontalo:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.gorontalo), barWidth);
                    break;
                case Province.jambi:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.jambi), barWidth);
                    break;
                case Province.jawa_barat:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.jawa_barat), barWidth);
                    break;
                case Province.jawa_tengah:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.jawa_tengah), barWidth);
                    break;
                case Province.jawa_timur:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.jawa_timur), barWidth);
                    break;
                case Province.kalimantan_barat:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.kalimantan_barat), barWidth);
                    break;
                case Province.kalimantan_selatan:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.kalimantan_selatan), barWidth);
                    break;
                case Province.kalimantan_tengah:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.kalimantan_tengah), barWidth);
                    break;
                case Province.kalimantan_timur:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.kalimantan_timur), barWidth);
                    break;
                case Province.kalimantan_utara:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.kalimantan_utara), barWidth);
                    break;
                case Province.kepulauan_bangka_belitung:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.kepulauan_bangka_belitung), barWidth);
                    break;
                case Province.kepulauan_riau:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.kepulauan_riau), barWidth);
                    break;
                case Province.lampung:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.lampung), barWidth);
                    break;
                case Province.luar_negeri:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.luar_negeri), barWidth);
                    break;
                case Province.maluku:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.maluku), barWidth);
                    break;
                case Province.maluku_utara:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.maluku_utara), barWidth);
                    break;
                case Province.ntb:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.ntb), barWidth);
                    break;
                case Province.ntt:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.ntt), barWidth);
                    break;
                case Province.papua:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.papua), barWidth);
                    break;
                case Province.papua_barat:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.papua_barat), barWidth);
                    break;
                case Province.riau:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.riau), barWidth);
                    break;
                case Province.sulawesi_barat:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.sulawesi_barat), barWidth);
                    break;
                case Province.sulawesi_selatan:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.sulawesi_selatan), barWidth);
                    break;
                case Province.sulawesi_tengah:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.sulawesi_tengah), barWidth);
                    break;
                case Province.sulawesi_tenggara:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.sulawesi_tenggara), barWidth);
                    break;
                case Province.sulawesi_utara:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.sulawesi_utara), barWidth);
                    break;
                case Province.sumatera_barat:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.sumatera_barat), barWidth);
                    break;
                case Province.sumatera_selatan:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.sumatera_selatan), barWidth);
                    break;
                case Province.sumatera_utara:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.sumatera_utara), barWidth);
                    break;
                case Province.yogyakarta:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.yogyakarta), barWidth);
                    break;
                case Province.total:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.GetTotalValue()), barWidth);
                    break;
                default:
                    Bar.transform.localScale = new Vector3(barWidth, normalizeValue(candidate.GetTotalValue()), barWidth);
                    break;
            }
        });
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
