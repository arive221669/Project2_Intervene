using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBergBehavior : MonoBehaviour
{
    private float timer;
    public GameObject IceBerg;

    private float minSize = 0.1f;

    private float shrinkSpeed = -0.1f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        Debug.Log("Time past: " + timer);

        if(timer >= 5)
        {
            IceBerg.transform.localScale += new Vector3(10, 5, 10) * shrinkSpeed * Time.deltaTime;

/*            if (IceBerg.transform.localScale < minSize)
            {

            }*/
        }
        
    }
}
