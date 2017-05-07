using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    float life_time = 10f;
    float time = 0f;

    // Use this for initialization
    // 左上向きの速度をセットする
    void Start () {
	    this.GetComponent<Rigidbody>().velocity = new Vector3(0.0f,15.0f,10.0f);
    }

    // Update is called once per frame
    //10秒後にオブジェクトを削除する
    void Update()
    {
        time += Time.deltaTime;
        if (time > life_time)
        {
            Destroy(this.gameObject);
        }

    }

    //画面外に出たらオブジェクトを削除する
        void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }


}
