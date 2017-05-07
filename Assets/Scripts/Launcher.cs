using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject ballPrefab;
	
	// Update is called once per frame
    //マウスの右ボタンが押されたらインスタンスを作成する
	void Update () {
	    if (Input.GetMouseButtonDown(1))
	    {
	        Instantiate(this.ballPrefab);
	    }
	}
}
