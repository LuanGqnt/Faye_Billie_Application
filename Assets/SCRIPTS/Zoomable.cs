using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zoomable : MonoBehaviour {

    [SerializeField] private Texture2D magnifierCursor;
    [SerializeField] private string sceneName;

    private Vector2 cursorHotspot;

    private StateManager stateManager;

    void Start() {
        stateManager = FindObjectOfType<StateManager>();
    }

    void OnMouseEnter() {
        if(stateManager.currentState != States.ZOOM) {
            Debug.Log("State is not ZOOM");
            return;
        }

        cursorHotspot = new Vector2(magnifierCursor.width / 2, magnifierCursor.height / 2);
        Cursor.SetCursor(magnifierCursor, cursorHotspot, CursorMode.Auto);
    }
    
    void OnMouseExit() {
        if(stateManager.currentState != States.ZOOM) {
            Debug.Log("State is not ZOOM");
            return;
        }

        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseDown() {
        if(stateManager.currentState != States.ZOOM) {
            Debug.Log("State is not ZOOM");
            return;
        }
        
        if(sceneName == "") {
            Debug.LogWarning("Zoomable does not have a scene!");
            return;
        }

        Debug.Log("Zooming into scene " + sceneName);
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        SceneManager.LoadScene(sceneName);
    }

}
