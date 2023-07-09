using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    [Header("スピード")] public float speed = 3.0f;
    [Header("最大移動時間")] public float maxdistance = 100.0f;
    private float slash_timer = 0.0f;

    

    void FixedUpdate()
    {
        transform.Translate(speed, 0, 0);
        // 親子関係の解消
        gameObject.transform.parent = null;

        if (slash_timer > maxdistance)
        {
            Destroy(gameObject);
        }
        else
        {
            slash_timer += Time.deltaTime;
        }

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        Imonezumi.instance.Sub40enemyHP();
        Destroy(this.gameObject);
    }



}
