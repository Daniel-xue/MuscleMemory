using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poke : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        this.gameObject.transform.localPosition = new Vector3(mousePos.x + 0.3f, mousePos.y - 0.3f); //設定鼠標點擊感應位置
    }
}
