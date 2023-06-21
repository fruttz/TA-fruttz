using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeNPC : MonoBehaviour
{
    public MeshRenderer headRenderer;
    public MeshRenderer bodyRenderer;
    public Material head1;
    public Material head2;
    public Material body1;
    public Material body2;
    public Material body3;
    void Start()
    {
        int headNumber = Random.Range(1,3);
        int bodyNumber = Random.Range(1,4);
        pickHeadMaterial(headNumber);
        pickBodyMaterial(bodyNumber);
    }

    private void pickHeadMaterial(int value){
        if (value == 1){
            headRenderer.material = head1;
        }
        else if (value == 2){
            headRenderer.material = head2;
        }
    }

    private void pickBodyMaterial(int value){
        if (value == 1){
            bodyRenderer.material = body1;
        }
        else if (value == 2){
            bodyRenderer.material = body2;
        }
        else if (value == 3){
            bodyRenderer.material = body3;
        }
    }

    
}
