using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizationChart : MonoBehaviour
{
    public DatabaseManager db;
    public GameObject candidateBar1;
    public GameObject candidateBar2;
    public float barWidth = 0.5f;
    public float barSpacing = 0.1f;
    public float chartHeight = 250f;
    public float updateInterval = 0.01f;

    private List<GameObject> bars = new List<GameObject>();
    private Candidate candidate1 = new Candidate("candidate1");
    private Candidate candidate2 = new Candidate("candidate2");
    private float nextUpdateTime = 0f;

    private float normalizeValue(int value){
        float newValue = (float)value * 0.001f;
        return newValue;
    }

    private void Start(){

        candidate1 = db.RetrieveData(candidate1);
        candidate2 = db.RetrieveData(candidate2);

        candidateBar1.transform.localScale = new Vector3(barWidth, normalizeValue(candidate1.aceh), barWidth);
        candidateBar2.transform.localScale = new Vector3(barWidth, normalizeValue(candidate2.aceh), barWidth);

    }

    private void Update() {
        if(Time.time > nextUpdateTime){
            db.UpdateData(candidate1);
            db.UpdateData(candidate2);

            db.RetrieveData(candidate1);
            db.RetrieveData(candidate2);


            candidateBar1.transform.localScale = new Vector3(barWidth, normalizeValue(candidate1.aceh), barWidth);
            candidateBar2.transform.localScale = new Vector3(barWidth, normalizeValue(candidate2.aceh), barWidth);
            Debug.Log(normalizeValue(candidate1.aceh));

            nextUpdateTime = Time.time + updateInterval;
        }
    }



}
