using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public AudioSource sound;
    private Vector2 spawnPoint = new Vector2(-10.5f, 0.53f);
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sound.Play();
        Teleport();
    }

    void Teleport()
    {
        player.transform.position = spawnPoint;
    }
}
