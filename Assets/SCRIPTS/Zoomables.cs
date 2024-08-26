using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zoomables : MonoBehaviour {

    [SerializeField] private string zoomOutScene;

    void Update() {
        if(Input.GetMouseButtonDown(1) && zoomOutScene != "")
            ZoomOut();
    }

    void ZoomOut() {
        SceneManager.LoadScene(zoomOutScene);
    }

}
