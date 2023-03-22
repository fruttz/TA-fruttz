using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Proyecto26;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public string db_url = "https://immersive-visualization-pemilu-default-rtdb.asia-southeast1.firebasedatabase.app/";
    Candidate candidate1 = new Candidate("candidate1");
    Candidate candidate2 = new Candidate("candidate2");
    public void RetrieveData(Candidate candidate){
        RestClient.Get<Candidate>(db_url + candidate.name + ".json").Then(response => {
            candidate = response;
        });
    }

    public void UpdateData(Candidate candidate){
        Candidate tempCandidate = new Candidate(candidate.name);
        tempCandidate.SetRandomValue();
        RestClient.Put(db_url + candidate.name + ".json", tempCandidate).Then(response => {
            Debug.Log("Status" + response.StatusCode.ToString() + "OK");
        });

    }

    public void ResetData(Candidate candidate){
        Candidate tempCandidate = new Candidate(candidate.name);
        tempCandidate.SetZero();
        RestClient.Put(db_url + candidate.name + ".json", tempCandidate).Then(response => {
            Debug.Log("Status" + response.StatusCode.ToString() + "OK");
        });
    }

    public void PutButton(){
        UpdateData(candidate1);
        UpdateData(candidate2);
    }
    

}
