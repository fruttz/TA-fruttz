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

    public void enableChart(){
        SetLayer(chart.transform, 0);
    }

    public void disableChart(){
        SetLayer(chart.transform, 6);
    }

    public string MapName(){
        return this.gameObject.name;
    }

    private void SetLayer(Transform obj, int newLayer)
    {
        obj.gameObject.layer = newLayer;

        foreach (Transform child in obj)
        {
            SetLayer(child, newLayer);
        }
    }

    void Start()
    {
        disableChart();
        mapRenderer = mapProvince.GetComponent<MeshRenderer>();
        
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
