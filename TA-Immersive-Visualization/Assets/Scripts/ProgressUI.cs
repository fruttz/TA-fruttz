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
    public TextMeshProUGUI voteCountText;
    public TextMeshProUGUI progressPercentage;
    public TextMeshProUGUI totalCountText;
    public Image mask;
    private int totalCount;
    private int current;
    private string db_url = "https://immersive-visualization-pemilu-default-rtdb.asia-southeast1.firebasedatabase.app/voter";

    private void Awake() {
        StartCoroutine(updateTotalCount());
    }

    void Update()
    {
        trackProgress();
    }

    private void trackProgress(){
        totalCount = int.Parse(totalCountText.text);
        current = int.Parse(bar1Value.text) + int.Parse(bar2Value.text);
        float fillAmount = (float) current / (float) totalCount;
        mask.fillAmount = fillAmount;

        voteCountText.text = current.ToString();

        float percentage = Mathf.Floor(fillAmount * 100f);
        progressPercentage.text = percentage.ToString();
    }

    private void setTotalCount(int value){
        totalCountText.text = value.ToString();
    }

    private void RetrieveVoterData(){
        RestClient.Get<VoterCount>(db_url + ".json").Then(response => {
            setTotalCount(response.voter_count_total);
        });
    }

    IEnumerator updateTotalCount(){
        while(true){
            RetrieveVoterData();
            yield return new WaitForSeconds(5);
        }
    }


}
