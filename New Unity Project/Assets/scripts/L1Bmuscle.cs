using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class L1Bmuscle : MonoBehaviour {
	public static List<string> questionBank;
	public AudioSource m1,m2,m3,m4,m5,m6,m7,m8,em1,em2, em3, em4, em5, em6, em7, em8;
	public GameObject a,b,c,d,e,f,g,h,ea,eb,ec,ed,ee,ef,eg,eh,aw,bw,cw,dw,ew,fw,gw,hw;
    public static int r;
	public Button reset;
    public static float avg_score, max1 = 0, max2 = 0;
    public Text title, TG, FM, SM, L, L1, L2, V, V1, V2, V3, V4, M, M1, M2, M3, M4,
     M5, M6, M7, M8, S, l_AS, v_AS, B, R, MN1, MN2, MN3, MN4, MN5, MN6, MN7, MN8,BTH;
    // Use this for initialization
    void Start () {
        SetData.wrong_clicks = 0;

        questionBank = new List<string>();
        if (SetData.ouo.language == "1"){
            questionBank.Add("斜方肌");
            questionBank.Add("肱三頭肌");
            questionBank.Add("三角肌");
            questionBank.Add("闊背肌");
            questionBank.Add("臀大肌");
            questionBank.Add("內收肌");
            questionBank.Add("大腿後肌群");
            questionBank.Add("腓腸肌");

            MN1.text = questionBank[0];
            MN2.text = questionBank[1];
            MN3.text = questionBank[2];
            MN4.text = questionBank[3];
            MN5.text = questionBank[4];
            MN6.text = questionBank[5];
            MN7.text = questionBank[6];
            MN8.text = questionBank[7];
            title.text = "肌肉記憶";
            TG.text = "目標";
            FM.text = "最快的";
            SM.text = "最慢的";
            L.text = "層級";
            L1.text = "層級1";
            L2.text = "層級2";
            V.text = "視圖";
            V1.text = "正面";
            V2.text = "背面";
            V3.text = "正面";
            V4.text = "背面";
            M.text = "模式";
            M1.text = "掃描";
            M2.text = "戳戳";
            M3.text = "掃描";
            M4.text = "戳戳";
            M5.text = "掃描";
            M6.text = "戳戳";
            M7.text = "掃描";
            M8.text = "戳戳";
            S.text = "得分";
            l_AS.text = "平均分";
            B.text = "開始";
            R.text = "重來";
            BTH.text = "回到首頁";
        }
        if (SetData.ouo.language == "2") {
            questionBank.Add("trapezius");
            questionBank.Add("triceps brachii");
            questionBank.Add("deltoid");
            questionBank.Add("adductors");
            questionBank.Add("gluteus maximus");
            questionBank.Add("latissimus dorsi");
            questionBank.Add("hamstrings");
            questionBank.Add("gastrocnemius");

            aw.name = "trapezius";
            bw.name = "triceps brachii";
            cw.name = "deltoid";
            dw.name = "adductors";
            ew.name = "gluteus maximus";
            fw.name = "latissimus dorsi";
            gw.name = "hamstrings";
            hw.name = "gastrocnemius";
        }
	}

	void L1BmuscleName(){
        if (questionBank.Count == 0) {
            avg_score = L1Bscore.total_score/8;
            if (SetData.currentlevel == 3){
                SetData.passed_level[2] = 1;
                if (avg_score > max1){
                    max1 = avg_score;
                }
            }
            if (SetData.currentlevel == 4){
                SetData.passed_level[3] = 1;
                if (avg_score > max2){
                    max2 = avg_score;
                }
            }

            v_AS.text = avg_score.ToString("00.0");
            GameObject.Find("EventSystem").SendMessage("maxscore");
			if (avg_score < 75) {
				GameObject.Find ("EventSystem").SendMessage ("show_score_sheet");
				GameObject.Find ("EventSystem").GetComponent<WinAndLose> ().SendMessage ("Lose");
			}
			else if (avg_score >= 75) {
				GameObject.Find ("EventSystem").SendMessage ("show_score_sheet");
				GameObject.Find ("EventSystem").GetComponent<WinAndLose> ().SendMessage ("Win");
			}
		}
        else{
            r = Random.Range(0, questionBank.Count - 1);
            TG.text = questionBank[r];
            SetData.ouo.answer = TG.text;
            if (SetData.currentlevel == 3){
                if (SetData.ouo.language == 1.ToString())
                {
                    if (a.name == TG.text){
                        m1.Play();
                        a.SetActive(true);
                        a.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (b.name == TG.text){
                        m2.Play();
                        b.SetActive(true);
                        b.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (c.name == TG.text){
                        m3.Play();
                        c.SetActive(true);
                        c.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (d.name == TG.text){
                        m4.Play();
                        d.SetActive(true);
                        d.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (e.name == TG.text){
                        m5.Play();
                        e.SetActive(true);
                        e.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (f.name == TG.text){
                        m6.Play();
                        f.SetActive(true);
                        f.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (g.name == TG.text){
                        m7.Play();
                        g.SetActive(true);
                        g.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (h.name == TG.text){
                        m8.Play();
                        h.SetActive(true);
                        h.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                }
                else if(SetData.ouo.language == 2.ToString())
                {
                    if (ea.name == TG.text){
                        em1.Play();
                        ea.SetActive(true);
                        ea.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (eb.name == TG.text){
                        em2.Play();
                        eb.SetActive(true);
                        eb.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ec.name == TG.text){
                        em3.Play();
                        ec.SetActive(true);
                        ec.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ed.name == TG.text){
                       em4.Play();
                       ed.SetActive(true);
                       ed.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ee.name == TG.text){
                        em5.Play();
                        ee.SetActive(true);
                        ee.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ef.name == TG.text){
                       em6.Play();
                       ef.SetActive(true);
                       ef.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (eg.name == TG.text){
                        em7.Play();
                        eg.SetActive(true);
                        eg.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (eh.name == TG.text){
                        em8.Play();
                        eh.SetActive(true);
                        eh.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                }
            }
            else if (SetData.currentlevel == 4){
                if (SetData.ouo.language == 1.ToString())
                {
                    if (a.name == TG.text){
                        a.SetActive(true);
                        m1.Play();
                    }
                    else if (b.name == TG.text){
                        b.SetActive(true);
                        m2.Play();
                    }
                    else if (c.name == TG.text){
                        c.SetActive(true);
                        m3.Play();
                    }
                    else if (d.name == TG.text){
                        d.SetActive(true);
                        m4.Play();
                    }
                    else if (e.name == TG.text){
                        e.SetActive(true);
                        m5.Play();
                    }
                    else if (f.name == TG.text){
                        f.SetActive(true);
                        m6.Play();
                    }
                    else if (g.name == TG.text){
                        g.SetActive(true);
                        m7.Play();
                    }
                    else if (h.name == TG.text){
                        h.SetActive(true);
                        m8.Play();
                    }
                }
                else if (SetData.ouo.language == 2.ToString())
                {
                    if (ea.name == TG.text){
                        ea.SetActive(true);
                        em1.Play();
                    }
                    else if (eb.name == TG.text){
                        eb.SetActive(true);
                        em2.Play();
                    }
                    else if (ec.name == TG.text){
                        ec.SetActive(true);
                        em3.Play();
                    }
                    else if (ed.name == TG.text){
                        ed.SetActive(true);
                        em4.Play();
                    }
                    else if (ee.name == TG.text){
                        ee.SetActive(true);
                        em5.Play();
                    }
                    else if (ef.name == TG.text){
                        ef.SetActive(true);
                        em6.Play();
                    }
                    else if (eg.name == TG.text){
                        eg.SetActive(true);
                        em7.Play();
                    }
                    else if (eh.name == TG.text){
                        eh.SetActive(true);
                        em8.Play();
                    }
                }
            }
        }
    }

    public void L1BmuscleObject(){
        if (SetData.ouo.language == 1.ToString())
        {
            if (a.name == TG.text)
            {
                a.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (b.name == TG.text)
            {
                b.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (c.name == TG.text)
            {
                c.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (d.name == TG.text)
            {
                d.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (e.name == TG.text)
            {
                e.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (f.name == TG.text)
            {
                f.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (g.name == TG.text)
            {
                g.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (h.name == TG.text)
            {
                h.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
        }
    }
}
