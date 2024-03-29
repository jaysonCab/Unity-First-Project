using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zirdScript : MonoBehaviour
{
    public Rigidbody2D zirdRigidBody;
    public float flapStrength;
    public LevelScript logic;
    public bool birdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LevelScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdAlive == true)
        {
            zirdRigidBody.velocity = Vector2.up * flapStrength;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdAlive = false;
    }

}
