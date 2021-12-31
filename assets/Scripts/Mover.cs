using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Default movement speed variable made visible in editor
    [SerializeField] float moveSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Specify movement based on user input
        // Multiply by Time.deltaTime for frame independency
        float moveSideways = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float moveForward = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float jump = Input.GetAxis("Jump");
        transform.Translate(moveSideways, moveForward, jump);
    }
}
