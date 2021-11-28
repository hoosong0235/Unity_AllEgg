using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float velocityThreshold = 3.0f;
    float playerSize;
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        this.rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && this.rigid.velocity.y <= 1 * this.velocityThreshold) this.rigid.velocity += new Vector2(0.0f, 0.1f);
        if (Input.GetKey(KeyCode.A) && this.rigid.velocity.x >= -1 * this.velocityThreshold) this.rigid.velocity += new Vector2(-0.1f, 0.0f);
        if (Input.GetKey(KeyCode.S) && this.rigid.velocity.y >= -1 * this.velocityThreshold) this.rigid.velocity += new Vector2(0.0f, -0.1f);
        if (Input.GetKey(KeyCode.D) && this.rigid.velocity.x <= 1 * this.velocityThreshold) this.rigid.velocity += new Vector2(0.1f, 0.0f);

        this.playerSize = Variables.playerSize;
        gameObject.transform.localScale = new Vector3(this.playerSize, this.playerSize, this.playerSize);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Variables.playerSize += 0.1f;
    }
}
