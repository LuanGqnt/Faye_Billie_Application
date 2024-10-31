using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zoomables : MonoBehaviour {

    [SerializeField] private string zoomOutScene;

    private StateManager stateManager;

    private InspectPanel inspectPanel;

    void Start() {
        stateManager = FindObjectOfType<StateManager>();
        inspectPanel = FindObjectOfType<InspectPanel>();
    }

    void Update() {
        if(Input.GetMouseButtonDown(1) && zoomOutScene != "" && stateManager.currentState == States.ZOOM)
            ZoomOut();
    }

    void ZoomOut() {
        Debug.Log("Zooming out to scene " + zoomOutScene);

        inspectPanel.Hide();
        SceneManager.LoadScene(zoomOutScene);
    }

}
