using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firepowerup : MonoBehaviour
{
    public GameObject bullet;
    public Sprite fireroo;
    public Sprite defaultStaff;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sr.sprite == fireroo)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, transform);
            }
        }
     
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Staff")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = defaultStaff;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Fire Firefly")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fireroo;
            Destroy(collision.gameObject);

            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, transform);
            }
        }
    }
}
