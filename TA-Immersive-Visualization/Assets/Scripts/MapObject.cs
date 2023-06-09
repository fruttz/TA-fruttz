using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapObject : MonoBehaviour
{
    public GameObject chart;
    public GameObject mapProvince;
    public GameObject candidate1Bar;
    public GameObject candidate2Bar;
    public Material candidate1Material;
    public Material candidate2Material;
    public Material defaultMaterial;
    private MeshRenderer mapRenderer;
    private float candidate1Height;
    private float candidate2Height;
    void Start()
    {
        mapRenderer = mapProvince.GetComponent<MeshRenderer>();
        //chart.SetActive(false);
    }

    void Update()
    {
        candidate1Height = candidate1Bar.transform.localScale.y;
        candidate2Height = candidate2Bar.transform.localScale.y;
        if (candidate1Height > candidate2Height){
            mapRenderer.material = candidate1Material;
        }
        else if (candidate1Height < candidate2Height){
            mapRenderer.material = candidate2Material;
        }
        else {
            mapRenderer.material = defaultMaterial;
        }
        
    }
}
