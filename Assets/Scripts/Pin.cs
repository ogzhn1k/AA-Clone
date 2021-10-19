using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
	private bool isPinned = false;
	public float speed = 20f;
	public Rigidbody2D rb;
    private void FixedUpdate()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rotator")
        {
            transform.SetParent(collision.transform);
            Score.PinCount++;
            //collision.GetComponent<Rotator>().rotationSpeed *= -1;
            isPinned = true;
        }
        else if (collision.tag == "Pin")
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}