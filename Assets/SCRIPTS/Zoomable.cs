using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zoomable : MonoBehaviour {

    [SerializeField] private Texture2D magnifierCursor;
    [SerializeField] private string sceneName;

    private Vector2 cursorHotspot;

    void OnMouseEnter() {
        cursorHotspot = new Vector2(magnifierCursor.width / 2, magnifierCursor.height / 2);
        Cursor.SetCursor(magnifierCursor, cursorHotspot, CursorMode.Auto);
    }
    
    void OnMouseExit() {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseDown() {
        if(sceneName == "") {
            Debug.LogWarning("Zoomable does not have a scene!");
            return;
        }

        Debug.Log("Changing scene to " + sceneName);
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        SceneManager.LoadScene(sceneName);
    }

}
