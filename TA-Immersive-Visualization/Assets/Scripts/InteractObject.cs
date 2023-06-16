using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractObject : MonoBehaviour
{
    public TextMeshProUGUI interactText;
    public TextMeshProUGUI objectText;
    public Transform raycastObjectOrigin;
    private Transform highlight;
    private Transform selection;
    private RaycastHit hit;

    private void Awake() {
        interactText.gameObject.SetActive(false);
        objectText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (highlight != null){
            highlight.gameObject.GetComponent<Outline>().enabled = false;
            highlight = null;
            interactText.gameObject.SetActive(false);
            objectText.gameObject.SetActive(false);
        }
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(raycastObjectOrigin.position, raycastObjectOrigin.TransformDirection(Vector3.forward), out hit, 250)){
            highlight = hit.transform;
            if (highlight.CompareTag("Selectable")){
                var mapScript = highlight.parent.GetComponent<MapObject>();
                interactText.gameObject.SetActive(true);
                objectText.gameObject.SetActive(true);
                objectText.text = mapScript.MapName();
                if (highlight.gameObject.GetComponent<Outline>() != null){
                    highlight.gameObject.GetComponent<Outline>().enabled = true;
                }
                else {
                    Outline outline = highlight.gameObject.AddComponent<Outline>();
                    outline.enabled = true;
                    highlight.gameObject.GetComponent<Outline>().OutlineColor = Color.white;
                    highlight.gameObject.GetComponent<Outline>().OutlineWidth = 7.0f;
                }
            }
            else {
                highlight = null;
                interactText.gameObject.SetActive(false);
                objectText.gameObject.SetActive(false);
            }
        }

        if (Input.GetKeyDown("e")){
            if (highlight && highlight != selection){
                if (selection != null){
                    selection.gameObject.GetComponent<Outline>().enabled = false;
                    interactText.gameObject.SetActive(false);
                    objectText.gameObject.SetActive(false);
                }
                selection = hit.transform;
                var mapScript = selection.parent.GetComponent<MapObject>();
                mapScript.enableChart();
                interactText.gameObject.SetActive(true);
                objectText.gameObject.SetActive(true);
                objectText.text = mapScript.MapName();
                selection.gameObject.GetComponent<Outline>().enabled = true;
                highlight = null;
            }
            else{
                if (selection){
                    var mapScript = selection.parent.GetComponent<MapObject>();
                    mapScript.disableChart();
                    selection.gameObject.GetComponent<Outline>().enabled = false;
                    selection = null;
                }
            }
        }

        
        
    }
}
