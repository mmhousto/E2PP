using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody2D>();
        var r = Random.Range(-1.0f, 1.0f);
        rb.AddForce(new Vector3(r, 0, 0) * 5.0f, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y <= -5.0)
        {
            Destroy(gameObject);
            spawner.deleteBall();
        }
    }
}
