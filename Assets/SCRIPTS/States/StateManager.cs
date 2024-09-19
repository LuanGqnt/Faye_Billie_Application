using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour {

    public States currentState;

    void Awake() {
        currentState = States.DEFAULT;
    }

    public void ChangeState(string state) {
        switch(state) {
            case "ZOOM":
                currentState = States.ZOOM;
                break;
            case "INSPECT":
                currentState = States.INSPECT;
                break;
            default:
                currentState = States.DEFAULT;
                break;
        }
    }

}
