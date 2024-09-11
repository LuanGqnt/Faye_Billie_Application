using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {

    private ParticleSystem particles;

    void Awake() {
        particles = GetComponent<ParticleSystem>();
    }

    void Start() {
        if(particles)
            particles.Play();
    }

}
