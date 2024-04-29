using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L2Bscore : MonoBehaviour {
	public List<float> scores;
	public List<string> names;
	public Text s1, s2, s3, s4, s5, s6,m1, m2, m3, m4, m5, m6;
	int a;
	static public float total_score;
	// Use this for initialization
	void Start () {
		total_score=0;
		scores = new List<float> ();
		names = new List<string> ();
		for(int i=0;i<15;i++){
			scores.Add(0.0f);
		}
        if (SetData.ouo.language == "1"){
			names.Add("斜方肌");
			names.Add("棘下肌");
			names.Add("三角肌");
			names.Add("大圓肌");
			names.Add("闊背肌");
			names.Add("豎脊肌");
			names.Add("肱三頭肌");
			names.Add("肱橈肌");
			names.Add("腕伸肌");
			names.Add("臀大肌");
			names.Add("內收肌");
			names.Add("股二頭肌");
			names.Add("半膜肌");
			names.Add("半腱肌");
			names.Add("腓腸肌");
		}
		else if (SetData.ouo.language == "2"){
			names.Add("trapezius");
			names.Add("deltoid");
			names.Add("infraspinatus");
			names.Add("teres najor");
			names.Add("latissimus dorsi");
			names.Add("triceps brachii");
			names.Add("erector spinae");
			names.Add("wrist extensors");
			names.Add("wrist flexors");
			names.Add("gluteus maximus");
			names.Add("adductors");
			names.Add("blceps femoris");
			names.Add("semimembranosus");
			names.Add("semitendinosus");
			names.Add("gastrocnemius");
		}
	}

	public void score0(){
		float s = (11-Timer.currentTime) * 10;
		if (s>100){s=100;}
        SetData.ouo.score = s;
		// 紀錄每個肌肉的分數
		for (int i = 0; i < scores.Count ;i++) {
			if(L2Bmuscle.questionBank[L2Bmuscle.r]==names[i]){
				scores[i] = s;
				break;
			}
		}
		L2Bmuscle.questionBank.RemoveAt(L2Bmuscle.r);
		// 計算總分
		total_score += s;
	}

	public void show_score_sheet(){
		float change;
		string change1;
		for(int i=0;i<14;i++){
			for(int j=0;j<14;j++){
				if(scores[i]>scores[j]){
					change =scores[i];
					scores[i]=scores[j];
					scores[j]=change;
					change1=names[i];
					names[i]=names[j];
					names[j]=change1;
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
