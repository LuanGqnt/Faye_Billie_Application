using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

    private DontDestroy[] dontDestroys;

    void Start() {
        dontDestroys = Object.FindObjectsOfType<DontDestroy>();

        for(int i = 0; i < dontDestroys.Length; i++) {
            if(dontDestroys[i] != this) {
                if(dontDestroys[i].name == gameObject.name) {
                    Destroy(gameObject);
                }
            }
        }

        DontDestroyOnLoad(gameObject);
    }

}
