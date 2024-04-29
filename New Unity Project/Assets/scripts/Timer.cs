using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {

    public Text rbTxt,target;
	public static bool currentTiming;
	public static float currentTime;
	public static int timeLimit=10;
	public bool Timing1;
	public float Time1;
	public GameObject w,color_muscle;
	bool flag1=false,flag2=false;
	public Image bar;

	void FixedUpdate () {
		if(Timing1){
			Time1 -= Time.fixedDeltaTime;
			rbTxt.text = ((int) Time1).ToString();
			if ((int)Time1 == 0) {
                color_muscle.SetActive(false);
				w.SetActive(true);
				rbTxt.gameObject.SetActive (false);
				Timing1 = false;
				currentTiming = true;
			}
		}
		if(currentTiming){
			bar.fillAmount = (timeLimit - currentTime) / 10;
			currentTime += Time.fixedDeltaTime;

			if(flag1 == false){
				if(SetData.currentlevel==1 || SetData.currentlevel==2){
					GameObject.Find ("L1-front").SendMessage ("L1FmuscleName");
				}
				else if(SetData.currentlevel==3 || SetData.currentlevel==4){
					GameObject.Find ("L1-back").SendMessage ("L1BmuscleName");
				}
				else if(SetData.currentlevel==5 || SetData.currentlevel==6){
					GameObject.Find ("L2-front").SendMessage ("L2FmuscleName");
				}
				else if(SetData.currentlevel==7 || SetData.currentlevel==8){
					GameObject.Find ("L2-back").SendMessage ("L2BmuscleName");
				}
				flag1 = true;
			}
			else if(flag1 == true){
				if (flag2 == false) {
					if ((int)currentTime == timeLimit/2) {
						if(SetData.currentlevel==2){
							GameObject.Find ("L1-front").SendMessage ("L1FmuscleObject");
						}
						else if(SetData.currentlevel==4){
							GameObject.Find ("L1-back").SendMessage ("L1BmuscleObject");
						}
						else if(SetData.currentlevel==6){
							GameObject.Find ("L2-front").SendMessage ("L2FmuscleObject");
						}
						else if(SetData.currentlevel==8){
							GameObject.Find ("L2-back").SendMessage ("L2BmuscleObject");
						}
						flag2 = true;
					}
				}
			}

			if ((int)currentTime == timeLimit) {
                GameObject.Find ("EventSystem").GetComponent<WinAndLose> ().SendMessage ("Lose");
				currentTime = 0;
			}
		}

	}

	public void Reactive_Timer1 () {  //重啟計時器
		rbTxt.gameObject.SetActive (true);
		Time1=4;
		Timing1 = true;
	}

	public void NextMuscle(){  //進到下一題
		currentTime = 0;
		SetData.wrong_clicks = 0;
		flag1 = false;
		flag2 = false;
	}
}