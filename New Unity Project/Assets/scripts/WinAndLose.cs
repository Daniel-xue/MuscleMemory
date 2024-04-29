using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinAndLose : MonoBehaviour {

	public Text target;
	public Button reset;
	public GameObject poke,scan;
    public AudioSource winMusic, loseMusic, bgMusic;
    public Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8;

    void unlock_button(){
        if(SetData.currentlevel > SetData.LastFinalLevel)
        {
            SetData.LastFinalLevel = SetData.currentlevel;
        }
        btn1.interactable = true;

        if (SetData.LastFinalLevel >= 2)
        {
            btn2.interactable = true;
        }
        if (SetData.LastFinalLevel >= 3)
        {
            btn3.interactable = true;
        }
        if (SetData.LastFinalLevel >= 4)
        {
            btn4.interactable = true;
        }
        if (SetData.LastFinalLevel >= 5)
        {
            btn5.interactable = true;
        }
        if (SetData.LastFinalLevel >= 6)
        {
            btn6.interactable = true;
        }
        if (SetData.LastFinalLevel >= 7)
        {
            btn7.interactable = true;
        }
        if (SetData.LastFinalLevel >= 8)
        {
            btn8.interactable = true;
        }
    }

    public void Win(){
        bgMusic.Pause();
        winMusic.Play();
        poke.SetActive(false);
        scan.SetActive(false);
        Cursor.visible = true;
        target.text = "過關";
		Timer.currentTiming = false;
        SetData.currentlevel = SetData.currentlevel+1;
        unlock_button();
    }

	public void Lose(){
        bgMusic.Pause();
        loseMusic.Play();
        poke.SetActive(false);
        scan.SetActive(false);
        Cursor.visible = true;
        target.text = "失敗";
		Timer.currentTiming = false;
        unlock_button();
    }
}
