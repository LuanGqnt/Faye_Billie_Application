using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectableMovement : MonoBehaviour {

    private Transform endPointsParent;
    private Transform chosenRootPoint;
    [SerializeField] private string endPointsParentName;

    private Vector3 offset;

    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;
    private float moveSpeed;

    [SerializeField] private float minScale = 0.1f;
    [SerializeField] private float maxScale = 0.25f;

    void Start() {
        endPointsParent = GameObject.Find(endPointsParentName).transform;
             
        // Setting a new size
        float newSize = Random.Range(minScale, maxScale);
        Vector3 newScale = new Vector3(newSize, newSize, newSize);

        moveSpeed = Random.Range(minSpeed, maxSpeed);

        transform.localScale = newScale;

        // Choosing a root point
        Transform[] rootPoints = endPointsParent.GetComponentsInChildren<Transform>();
        chosenRootPoint = rootPoints[Random.Range(1, rootPoints.Length)];

        // offset = new Vector3(Random.Range(-6f, 6f), -7f, Random.Range(-6f, 6f));
        // transform.position = chosenRootPoint.transform.position + offset;
    }

    void Update() {
        // Move towards the root
        transform.position = Vector3.MoveTowards(transform.position, chosenRootPoint.transform.position, moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.tag == "Destroyer" && col.transform == chosenRootPoint.transform)
            Destroy(this.gameObject);
    }

}
