using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PauseManager : MonoBehaviour {

    public static bool paused;
    public TextMeshProUGUI pauseUI;

    public void PauseResumeButton() {
        if(paused) {
            pauseUI.text = "Pause";
            Resume();
        } else {
            pauseUI.text = "Resume";
            Pause();
        }
    }

    public void Pause() {
        paused = true;
        Time.timeScale = 0f;
    }
    public void Resume() {
        paused = false;
        Time.timeScale = 1f;
    }

}
