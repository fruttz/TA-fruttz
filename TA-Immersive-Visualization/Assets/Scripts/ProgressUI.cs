using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressUI : MonoBehaviour
{
    public TextMeshPro bar1Value;
    public TextMeshPro bar2Value;
    public TextMeshProUGUI daysText;
    public TextMeshProUGUI progressPercentage;
    public Image mask;
    private int current;
    private string db_url = "https://immersive-visualization-pemilu-default-rtdb.asia-southeast1.firebasedatabase.app/time";
    private const int TOTAL = 150000000;

    private void Start() {
        StartCoroutine(trackTime());
    }

    void Update()
    {
        trackProgress();
    }

    private void trackProgress(){
        current = int.Parse(bar1Value.text) + int.Parse(bar2Value.text);
        float fillAmount = (float) current / (float) TOTAL;
        mask.fillAmount = fillAmount;

        float percentage = Mathf.Floor(fillAmount * 100f);
        progressPercentage.text = percentage.ToString();
    }

    private void setProgressDays(int value){
        daysText.text = value.ToString();
    }

    private void RetrieveTimeData(){
        RestClient.Get<TimeTracker>(db_url + ".json").Then(response => {
            setProgressDays(response.days_passed);
        });
    }

    IEnumerator trackTime(){
        while (true){
            RetrieveTimeData();
            yield return new WaitForSecondsRealtime(5);
        }
    }

}
