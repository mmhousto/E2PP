using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody2D>();
        var r = Random.Range(-1.0f, 1.0f);
        rb.AddForce(new Vector3(r, 0, 0) * 7.5f, ForceMode2D.Impulse);
        StartCoroutine("hit");
    }

    IEnumerator hit()
    {
        while (true)
        {
            var rb = GetComponent<Rigidbody2D>();
            var r = Random.Range(-1.0f, 1.0f);
            rb.AddForce(new Vector3(r, 0, 0) * 7.5f, ForceMode2D.Impulse);
            yield return new WaitForSeconds(3.0f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
