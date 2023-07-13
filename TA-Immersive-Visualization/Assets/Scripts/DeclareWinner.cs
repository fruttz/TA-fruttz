using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeclareWinner : MonoBehaviour
{
    public TextMeshProUGUI progressText;
    public TextMeshProUGUI totalText;
    public TextMeshPro value1;
    public TextMeshPro value2;
    public GameObject bar1;
    public GameObject bar2;
    public GameObject cube1;
    public GameObject cube2;
    public Material winnerMaterial;
    private int totalCount;

    void Start()
    {
        totalCount = int.Parse(totalText.text);
    }

    void Update()
    {
        float bar1Height = bar1.transform.localScale.y;
        float bar2Height = bar2.transform.localScale.y;
        if (int.Parse(progressText.text) >= 100){
            if (bar1Height > bar2Height){
                cube1.GetComponent<MeshRenderer>().material = winnerMaterial;
                value2.text = (totalCount - int.Parse(value1.text)).ToString();
            }
            else {
                cube2.GetComponent<MeshRenderer>().material = winnerMaterial;
                value1.text = (totalCount - int.Parse(value2.text)).ToString();
            }
        }
    }
}
