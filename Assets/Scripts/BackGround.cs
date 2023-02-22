using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Area"))
        {
            Debug.Log("asd");
        }
    }
}
