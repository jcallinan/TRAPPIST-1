using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitController : MonoBehaviour
{
    public Transform orbitPivot;
    public float orbitSpeed;
    public float rotationSpeed;
    public float planetRadius;
    public float distFromStar;
    // Start is called before the first frame update
    void Start()
    {
        //create a random positino along the orbit path
        Vector2 randomPosition = Random.insideUnitCircle;
        transform.position = new Vector3(randomPosition.x, 0f, randomPosition.y) * distFromStar;
        //set the size of the GameObject to the PlantRaduis value
        transform.localScale = Vector3.one * planetRadius;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(orbitPivot.position,Vector3.up, orbitSpeed * Time.deltaTime);
        this.transform.Rotate(Vector3.up,rotationSpeed * Time.deltaTime);
    }
}
