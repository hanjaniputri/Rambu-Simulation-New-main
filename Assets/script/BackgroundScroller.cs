using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float speed = 2f; // kecepatan gerak ke bawah
    public float resetPositionY = -10f; // posisi Y saat harus di-reset ke atas
    public float startPositionY = 10f;  // posisi awal saat di-reset
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y <= resetPositionY)
        {
            Vector3 pos = transform.position;
            pos.y = startPositionY;
            transform.position = pos;
        }
    }
}