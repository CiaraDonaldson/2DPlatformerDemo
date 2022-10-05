using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.SetParent(null);

        Invoke("Delete", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }


    public void Delete()
    {
        Destroy(gameObject);

    }

}
