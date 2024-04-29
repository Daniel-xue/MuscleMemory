using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L1Fscore : MonoBehaviour {

	public static List<float> scores;
	public static List<string> names;
	public Text s1, s2, s3, s4, s5, s6,m1, m2, m3, m4, m5, m6;
	int a;
	static public float total_score;
	// Use this for initialization
	void Start () {
		total_score=0;
		scores = new List<float> ();
		names = new List<string> ();
		for(int i=0;i<7;i++){
			scores.Add(0.0f);
		}
        if (SetData.ouo.language == "1")
        {
			names.Add("胸大肌");
			names.Add("三角肌");
			names.Add("肱二頭肌");
			names.Add("腹外斜肌");
			names.Add("腹直肌");
			names.Add("內收肌");
			names.Add("股四頭肌");
		}
		else if (SetData.ouo.language == "2")
        {
			names.Add("deltoid");
			names.Add("pectoralis major");
			names.Add("biceps brachii");
			names.Add("rectus abdominis");
			names.Add("extermal obliques");
			names.Add("adductors");
			names.Add("quadriceps");
		}
	}

	public void score0(){
		float s = (11-Timer.currentTime) * 10;
		if (s>100){s=100;}
        SetData.ouo.score = s;
		// 紀算該肌肉的分數
		for (int i = 0; i < scores.Count ;i++) {
			if(L1Fmuscle.questionBank[L1Fmuscle.r]==names[i]){
				scores[i] = s;
				break;
			}
		}
		L1Fmuscle.questionBank.RemoveAt(L1Fmuscle.r);
		// 計算總分
		total_score += s;
	}

	public void show_score_sheet(){
		float change1;
		string change2;

		for(int i=0;i<7;i++){
			for(int j=0;j<7;j++){
				if(scores[i]>scores[j]){

					change1 =scores[i];
					scores[i]=scores[j];
					scores[j]=change1;

					change2=names[i];
					names[i]=names[j];
					names[j]=change2;
				}
			}
		}
		m1.text = names [0];
		m2.text = names [1];
		m3.text = names [2];
		m4.text = names [4];
		m5.text = names [5];
		m6.text = names [6];
		s1.text=scores[0].ToString("00.0");
		s2.text=scores[1].ToString("00.0");
		s3.text=scores[2].ToString("00.0");
		s4.text=scores[4].ToString("00.0");
		s5.text=scores[5].ToString("00.0");
		s6.text=scores[6].ToString("00.0");
	}
}