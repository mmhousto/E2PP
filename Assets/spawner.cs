using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject cannonBall;
    private static int ballsInPlay = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spawn");
    }

    IEnumerator spawn()
    {
        while (true)
        {
            var r = Random.Range(-7.0f, 7.0f);
            if (ballsInPlay < 10)
            {
                Instantiate(cannonBall, new Vector3(r, 3.25f, -5), Quaternion.identity);
                ballsInPlay += 1;
            }
            yield return new WaitForSeconds(0.5f);
        }
        
    }

    public static void deleteBall()
    {
        ballsInPlay -= 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
