﻿using UnityEngine;

public class DropObjectDestroyer : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}