using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrongMuscClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("點錯了"+this.name);
        SetData.wrong_clicks += 1;  //點錯次數+1
        SetData.ouo.position = this.name;  //存取當下點擊之肌肉
        sql.transferData();  //寫入資料庫
    }
}
