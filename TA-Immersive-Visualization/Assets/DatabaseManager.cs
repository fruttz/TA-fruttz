using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Proyecto26;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public string db_url = "https://immersive-visualization-pemilu-default-rtdb.asia-southeast1.firebasedatabase.app/";

    public Candidate RetrieveData(Candidate candidate){
        RestClient.Get<Candidate>(db_url + candidate.name + ".json").Then(response => {
            candidate.CopyCandidate(response);
        });
        return candidate;
    }

    public void UpdateData(Candidate candidate){
        candidate.SetRandomValue();
        RestClient.Put(db_url + candidate.name + ".json", candidate).Then(response => {
            //Debug.Log("Status" + response.StatusCode.ToString() + "OK");
        });
    }

    public void ResetData(Candidate candidate){
        candidate.SetZero();
        RestClient.Put(db_url + candidate.name + ".json", candidate).Then(response => {
            //Debug.Log("Status" + response.StatusCode.ToString() + "OK");
        });
    }


}
