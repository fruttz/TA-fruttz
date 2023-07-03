using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractObject : MonoBehaviour
{
    public TextMeshProUGUI objectText;
    public GameObject interactionUI;
    public Transform raycastObjectOrigin;
    public InputActionProperty activate;
    public LineRenderer laser;
    private Transform highlight;
    private Transform selection;
    private RaycastHit hit;
    [SerializeField] private int range;

    private void Awake() {
        interactionUI.SetActive(false);
    }

    void Update()
    {
        if (highlight != null){
            highlight.gameObject.GetComponent<Outline>().enabled = false;
            highlight = null;
            interactionUI.SetActive(false);
        }
        if (Physics.Raycast(raycastObjectOrigin.position, raycastObjectOrigin.TransformDirection(Vector3.forward), out hit, range)){
            highlight = hit.transform;
            if (highlight.CompareTag("Selectable")){
                var mapScript = highlight.parent.GetComponent<MapObject>();
                interactionUI.SetActive(true);
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
                interactionUI.SetActive(false);
            }
        }

        if (Input.GetKeyDown("e") || activate.action.ReadValue<float>() >= 0.5){
            if (highlight && highlight != selection){
                if (selection != null){
                    selection.gameObject.GetComponent<Outline>().enabled = false;
                    interactionUI.SetActive(false);
                }
                selection = hit.transform;
                var mapScript = selection.parent.GetComponent<MapObject>();
                mapScript.enableChart();
                interactionUI.SetActive(true);
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

    public void enableLaser(){
        laser.enabled = true;
        laser.SetPosition(0, raycastObjectOrigin.position);
        laser.SetPosition(1, raycastObjectOrigin.position + (raycastObjectOrigin.forward * range));
    }

    public void disableLaser(){
        laser.enabled = false;
    }
}
