using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    Candidate candidate = new Candidate();
    public void RetrieveData(){
        RestClient.Get<Candidate>("https://immersive-visualization-pemilu-default-rtdb.asia-southeast1.firebasedatabase.app/candidate1.json").Then(response => {
            candidate = response;
            Debug.Log(candidate.aceh);
        });
    }
}
