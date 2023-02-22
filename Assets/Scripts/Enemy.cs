using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D EnemyRg;

    void Start()
    {
        EnemyRg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, GameManager.instance.player.transform.position, 3f * Time.deltaTime);
    }
}
