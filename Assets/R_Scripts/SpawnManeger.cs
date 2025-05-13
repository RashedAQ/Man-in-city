using UnityEngine;

public class SpawnManeger : MonoBehaviour
{
    public GameObject ObjectName;
    private Vector3 spawnObj = new Vector3(25,0,0);
    private float startDelay = 2;
    private float repetRate = 2;
    private PlayerMovement PlayerMovementScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
        InvokeRepeating("SpawnManger", startDelay, repetRate);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    void SpawnManger()
    {
        if(PlayerMovementScript.gameoverT == false)
        {
            Instantiate(ObjectName, spawnObj, ObjectName.transform.rotation);
        }
        
    }
}
