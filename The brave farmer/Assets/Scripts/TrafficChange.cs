using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficChange : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Cart"))
        {
            collision.GetComponent<Cart>().Change();
        }
    }
}
