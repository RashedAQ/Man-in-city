using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float MoveLeftSpeed = 30f;
    private float leftBoundery = -10f;
    private PlayerMovement PlayerMovementScrept;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerMovementScrept = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovementScrept.gameoverT == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * MoveLeftSpeed);
        }
        if(transform.position.x <leftBoundery && gameObject.CompareTag("obstcale"))
        {
            Destroy(gameObject);
        }
      
    }
}
