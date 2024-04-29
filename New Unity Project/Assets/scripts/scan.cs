using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scan : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y);  //設定鼠標點擊感應位置
    }
}
