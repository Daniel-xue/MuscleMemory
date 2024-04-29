using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMuscClick : MonoBehaviour
{

    public AudioSource rm;

    void OnMouseDown()
    {
        Debug.Log("點對了" + this.name);
        rm.Play(); //播放rm音效
        this.gameObject.SetActive(false);  //隱藏該物件
        GameObject.Find("EventSystem").SendMessage("score0");  //計算該題分數
        GameObject.Find("EventSystem").SendMessage("NextMuscle");  //進入下一題
        SetData.ouo.position = this.name;  //存取當下點擊之位置
        sql.transferData();  //寫入資料庫
    }
}