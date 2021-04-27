using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeslovescript : MonoBehaviour
{
    Material material;
    bool isDissolving = false;
    float fade = 1f;
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isDissolving)
            {
                isDissolving = false;
            } else
            {
                isDissolving = true;
            }

        }





        if (isDissolving)
        {
            fade -= Time.deltaTime;
            if (fade<=0)
            {
                fade = 0f;
                isDissolving = false;
            }
            material.SetFloat("_fade", fade);
        }
        else
        {
            fade += Time.deltaTime;
            if (fade >= 1)
            {
                fade = 1f;
                isDissolving = true;
            }
            material.SetFloat("_fade", fade);
        }
    }
}
