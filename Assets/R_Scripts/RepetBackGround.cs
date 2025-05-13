using Unity.Collections;
using UnityEngine;

public class RepetBackGround : MonoBehaviour
{

    private Vector3 spawnPos;
    private float repetwith;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPos = transform.position;
        repetwith = GetComponent<BoxCollider>().size.x / 2 ;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < spawnPos.x - repetwith)
        {
            transform.position = spawnPos;
        }
    }
}
