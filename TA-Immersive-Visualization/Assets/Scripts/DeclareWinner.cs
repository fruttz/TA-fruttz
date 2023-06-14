using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeclareWinner : MonoBehaviour
{
    public TextMeshProUGUI progressText;
    public GameObject bar1;
    public GameObject bar2;
    public GameObject cube1;
    public GameObject cube2;
    public Material winnerMaterial;

    void Update()
    {
        float bar1Height = bar1.transform.localScale.y;
        float bar2Height = bar2.transform.localScale.y;
        if (progressText.text == "100"){
            if (bar1Height > bar2Height){
                cube1.GetComponent<MeshRenderer>().material = winnerMaterial;
            }
            else {
                cube2.GetComponent<MeshRenderer>().material = winnerMaterial;
            }
        }
    }
}
