using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject objectToSpawn;
    public float minRate;
    public float maxRate;
    
    public Vector3 minPosition;
    public Vector3 maxPosition;

    private float rate;

    void Start() {
        rate = Random.Range(minRate, maxRate);
    }

    void Update() {
        if(rate <= 0f) {
            Spawn(Random.Range(1, 3));
            rate = Random.Range(minRate, maxRate);
        } else {
            rate -= Time.deltaTime;
        }
    }

    void Spawn(int amount) {
        for(int i = 0; i < amount; i++) {
            Vector3 positionToSpawn = new Vector3(Random.Range(minPosition.x, maxPosition.x), Random.Range(minPosition.y, maxPosition.y), Random.Range(minPosition.z, maxPosition.z));

            Instantiate(objectToSpawn, positionToSpawn, Quaternion.identity);
        }
    }

}
