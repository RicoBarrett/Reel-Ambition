using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralPlacement : MonoBehaviour
{
    public GameObject placementOne;
    public GameObject placementTwo;

    public Vector3 placementOnePosition;
    public Vector3 placementTwoPosition;

    public Vector3[] positions;

    public Grid gridOne;
    public Grid gridTwo;


    // Start is called before the first frame update
    void Start()
    {
        positions = new Vector3[2];

        placementOnePosition = placementOne.transform.position;
        placementTwoPosition = placementTwo.transform.position;

        positions[0] = placementOnePosition;
        positions[1] = placementTwoPosition;

        this.transform.position = positions[Random.Range(0, 2)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
