using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControler : MonoBehaviour
{
    public AudioSource bgMusicAudioSource;
	public GameObject scan,poke,skin;

	public void Begin(){
        SetData.ouo.times += 1;  //遊玩次數+1
        bgMusicAudioSource.Play();
        Cursor.visible = false;
        if (SetData.currentlevel % 2 == 1) {  //啟用scan模式
			skin.gameObject.SetActive (true); //顯示人體肌膚
			scan.gameObject.SetActive (true);  //顯示scan用鼠標
			SetData.wrong_clicks = 0;
			GameObject.Find ("EventSystem").GetComponent<Timer> ().SendMessage ("Reactive_Timer1");  //重啟計時器
		} else {  //啟用poke模式
			poke.gameObject.SetActive (true);  //顯示poke用鼠標
            GameObject.Find ("EventSystem").GetComponent<Timer>().SendMessage ("Reactive_Timer1");  //重啟計時器
        }
	}

    public void Back_to_home() //回到首頁
    {
        SceneManager.LoadScene("Login page");
    }
}
