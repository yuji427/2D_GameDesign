using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTestV3 : MonoBehaviour
{
    
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 rubyMove = transform.position;
        rubyMove.x = rubyMove.x + Input.GetAxis("Horizontal") * moveSpeed;
        rubyMove.y = rubyMove.y + Input.GetAxis("Vertical") * moveSpeed;
        transform.position = rubyMove;
    }
}