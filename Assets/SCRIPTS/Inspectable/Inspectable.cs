using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspectable : MonoBehaviour {

    public string name_;
    public string element;
    public string description;
    public Texture image;

    public StateManager stateManager;
    public InspectPanel inspectPanel;

    void Start() {
        stateManager = FindObjectOfType<StateManager>();
        inspectPanel = FindObjectOfType<InspectPanel>();
    }

    void OnMouseDown() {
        Debug.Log(stateManager.currentState);

        if(stateManager.currentState != States.INSPECT) {
            return;
        }

        inspectPanel.Inspect(name_, element, description, image);
    }

}
