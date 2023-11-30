using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayers;
    
    private Vector3 _moverDirection;
    
    private bool isGrounded;
    private Rigidbody rb;
    private float depth;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        depth = GetComponent<Collider>().bounds.size.y;
    }

    public void SetMoveDirection(Vector2 direction)
    {
        _moverDirection.x = direction.x;
        _moverDirection.z = direction.y;
    }

    private void CheckGround()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, depth, groundLayers);
        Debug.DrawRay(transform.position, Vector3.down * depth, Color.green, 0, false);
    }
}
