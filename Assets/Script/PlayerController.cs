using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontalInput;
    public float speed = 15f;
    public float xRange = 10f;
    public GameObject[] foodPrefab;
    public float foodTimer = 0.2f;
    private float foodTimerCounter = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        foodTimerCounter -= Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space)&&foodTimerCounter<0)
        {
            foodTimerCounter = foodTimer;
            int i = Random.Range(0, foodPrefab.Length );
            Instantiate(foodPrefab[i], new Vector3(transform.position.x,1,transform.position.z), foodPrefab[i].transform.rotation);
        }
    }

    private void Movement()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        if (transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); ;
        if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        transform.Translate(horizontalInput * Vector3.right * speed * Time.deltaTime);
    }
}
