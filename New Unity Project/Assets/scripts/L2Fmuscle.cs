using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class L2Fmuscle : MonoBehaviour {
	public static List<string> questionBank;
    public AudioSource bgMusicAudioSource;
    public Text title, TG, FM, SM, L, L1, L2, V, V1, V2, V3, V4, M, M1, M2, M3, M4, M5, M6, M7, M8, S, l_AS, v_AS, B, R, MN1, MN2, MN3, MN4, MN5, MN6, MN7, MN8, MN9, MN10, MN11, MN12, MN13, MN14, MN15, MN16,BTH;
    public AudioSource s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,s11,s12,s13,s14,s15,s16,
    es1, es2, es3, es4, es5, es6, es7, es8, es9, es10, es11, es12, es13, es14, es15, es16;
    public GameObject a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p;
    public GameObject ea, eb, ec, ed, ee, ef, eg, eh, ei, ej, ek, el, em, en, eo, ep;
    public GameObject aw, bw, cw, dw, ew, fw, gw, hw, iw, jw, kw, lw, mw, nw, ow, pw;
    public static int r;
	public Button reset;
	public Button btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8;
    public static float avg_score, max1 = 0, max2 = 0;
    // Use this for initialization
    void Start () {
        SetData.wrong_clicks = 0;

        questionBank = new List<string>();
        if (SetData.ouo.language == 1.ToString()){
            questionBank.Add("斜方肌");
            questionBank.Add("三角肌");
            questionBank.Add("胸大肌");
            questionBank.Add("肱二頭肌");
            questionBank.Add("前鋸肌");
            questionBank.Add("腹直肌");
            questionBank.Add("腹外斜肌");
            questionBank.Add("肱橈肌");
            questionBank.Add("腕屈肌");
            questionBank.Add("內收肌");
            questionBank.Add("縫匠肌");
            questionBank.Add("股直肌");
            questionBank.Add("股外側肌");
            questionBank.Add("股內側肌");
            questionBank.Add("脛前肌");
            questionBank.Add("腓腸肌");
        }
        else if(SetData.ouo.language == 2.ToString()){
            questionBank.Add("trapezius");
            questionBank.Add("deltoid");
            questionBank.Add("pectoralis major");
            questionBank.Add("biceps brachii");
            questionBank.Add("serratus anterior");
            questionBank.Add("external obliques");
            questionBank.Add("rectus abdominis");
            questionBank.Add("brachioradialis");
            questionBank.Add("wrist flexors");
            questionBank.Add("adductors");
            questionBank.Add("sartorius");
            questionBank.Add("rectus femoris");
            questionBank.Add("vastus lateralis");
            questionBank.Add("vastus medlalis");
            questionBank.Add("tibialls antenor");
            questionBank.Add("gastrocnemius");

            MN1.text = questionBank[0];
            MN2.text = questionBank[1];
            MN3.text = questionBank[2];
            MN4.text = questionBank[3];
            MN5.text = questionBank[4];
            MN6.text = questionBank[5];
            MN7.text = questionBank[6];
            MN8.text = questionBank[7];
            MN9.text = questionBank[8];
            MN10.text = questionBank[9];
            MN11.text = questionBank[10];
            MN12.text = questionBank[11];
            MN13.text = questionBank[12];
            MN14.text = questionBank[13];
            MN15.text = questionBank[14];
            MN16.text = questionBank[15];
            title.text = "Muscle Memory";
            TG.text = "target";
            FM.text = "fastest";
            SM.text = "slowest";
            L.text = "level";
            L1.text = "level 1";
            L2.text = "level 2";
            V.text = "view";
            V1.text = "front";
            V2.text = "back";
            V3.text = "front";
            V4.text = "back";
            M.text = "module";
            M1.text = "scan";
            M2.text = "poke";
            M3.text = "scan";
            M4.text = "poke";
            M5.text = "scan";
            M6.text = "poke";
            M7.text = "scan";
            M8.text = "poke";
            S.text = "score";
            l_AS.text = "Average Score";
            B.text = "begin";
            R.text = "reset";
            BTH.text = "back to home";

            aw.name = "trapezius";
            bw.name = "pectoralis major";
            cw.name = "tibialls antenor";
            dw.name = "deltoid";
            ew.name = "biceps brachii";
            fw.name = "serratus anterior";
            gw.name = "rectus abdominis";
            hw.name = "external obliques";
            iw.name = "wrist flexors";
            jw.name = "brachioradialis";
            kw.name = "adductor";
            lw.name = "sartorius";
            mw.name = "rectus abdominis";
            nw.name = "vastus medlalis";
            ow.name = "vastus lateralis";
            pw.name = "gastrocnemius";
        }
	}

	void L2FmuscleName(){
        if (questionBank.Count == 0) {
            avg_score = L2Fscore.total_score/16;
            if (SetData.currentlevel == 5){
                if (avg_score > max1){
                    max1 = avg_score;
                }
            }
            if (SetData.currentlevel == 6){
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
				if (SetData.currentlevel == 5) {
					btn1.interactable = true;
					btn2.interactable = true;
					btn3.interactable = true;
					btn4.interactable = true;
					btn5.interactable = true;
					btn6.interactable = true;
                }
				else if(SetData.currentlevel == 6) {
					btn1.interactable = true;
					btn2.interactable = true;
					btn3.interactable = true;
					btn4.interactable = true;
					btn5.interactable = true;
					btn6.interactable = true;
                    btn7.interactable = true;
                }
				GameObject.Find ("EventSystem").SendMessage ("show_score_sheet");
				GameObject.Find ("EventSystem").GetComponent<WinAndLose> ().SendMessage ("Win");
			}
        }
		else {
			r = Random.Range (0,questionBank.Count-1);
			TG.text = questionBank[r];
            SetData.ouo.answer = TG.text;
            if (SetData.currentlevel== 5){
                if (SetData.ouo.language == 1.ToString()){
                    if (a.name == TG.text){
                        s1.Play();
                        a.SetActive(true);
                        a.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (b.name == TG.text){
                        s2.Play();
                        b.SetActive(true);
                        b.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (c.name == TG.text){
                        s3.Play();
                        c.SetActive(true);
                        c.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (d.name == TG.text){
                        s4.Play();
                        d.SetActive(true);
                        d.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (e.name == TG.text){
                        s5.Play();
                        e.SetActive(true);
                        e.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (f.name == TG.text){
                        s6.Play();
                        f.SetActive(true);
                        f.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (g.name == TG.text){
                        s7.Play();
                        g.SetActive(true);
                        g.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (h.name == TG.text){
                        s8.Play();
                        h.SetActive(true);
                        h.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (i.name == TG.text){
                        s9.Play();
                        i.SetActive(true);
                        i.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (j.name == TG.text){
                        s10.Play();
                        j.SetActive(true);
                        j.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (k.name == TG.text){
                        k.SetActive(true);
                        k.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (l.name == TG.text){
                        s12.Play();
                        l.SetActive(true);
                        l.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (m.name == TG.text){
                        s13.Play();
                        m.SetActive(true);
                        m.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (n.name == TG.text){
                        s14.Play();
                        n.SetActive(true);
                        n.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (o.name == TG.text){
                        s15.Play();
                        o.SetActive(true);
                        o.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (p.name == TG.text){
                        s16.Play();
                        p.SetActive(true);
                        p.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                }
                else if (SetData.ouo.language == 2.ToString()){
                    if (ea.name == TG.text){
                        es1.Play();
                        ea.SetActive(true);
                        ea.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (eb.name == TG.text){
                        es2.Play();
                        eb.SetActive(true);
                        eb.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ec.name == TG.text){
                        es3.Play();
                        ec.SetActive(true);
                        ec.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ed.name == TG.text){
                        es4.Play();
                        ed.SetActive(true);
                        ed.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ee.name == TG.text){
                        es5.Play();
                        ee.SetActive(true);
                        ee.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ef.name == TG.text){
                        es6.Play();
                        ef.SetActive(true);
                        ef.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (eg.name == TG.text){
                        es7.Play();
                        eg.SetActive(true);
                        eg.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (eh.name == TG.text){
                        es8.Play();
                        eh.SetActive(true);
                        eh.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ei.name == TG.text){
                        es9.Play();
                        ei.SetActive(true);
                        ei.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ej.name == TG.text){
                        es10.Play();
                        ej.SetActive(true);
                        ej.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ek.name == TG.text){
                        ek.SetActive(true);
                        ek.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (el.name == TG.text){
                        es12.Play();
                        el.SetActive(true);
                        el.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (em.name == TG.text){
                       es13.Play();
                       em.SetActive(true);
                       em.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (en.name == TG.text){
                        es14.Play();
                        en.SetActive(true);
                        en.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (eo.name == TG.text){
                        es15.Play();
                        eo.SetActive(true);
                        eo.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ep.name == TG.text){
                        es16.Play();
                        ep.SetActive(true);
                        ep.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                }
            }
            else if (SetData.currentlevel == 6){
                if (SetData.ouo.language == 1.ToString()){
                    if (a.name == TG.text){
                        a.SetActive(true);
                        s1.Play();
                    }
                    else if (b.name == TG.text){
                        b.SetActive(true);
                        s2.Play();
                    }
                    else if (c.name == TG.text){
                        c.SetActive(true);
                        s3.Play();
                    }
                    else if (d.name == TG.text){
                        d.SetActive(true);
                        s4.Play();
                    }
                    else if (e.name == TG.text){
                        e.SetActive(true);
                        s5.Play();
                    }
                    else if (f.name == TG.text){
                        f.SetActive(true);
                        s6.Play();
                    }
                    else if (g.name == TG.text){
                        g.SetActive(true);
                        s7.Play();
                    }
                    else if (h.name == TG.text){
                        h.SetActive(true);
                        s8.Play();
                    }
                    else if (i.name == TG.text){
                        i.SetActive(true);
                        s9.Play();
                    }
                    else if (j.name == TG.text){
                        j.SetActive(true);
                        s10.Play();
                    }
                    else if (k.name == TG.text){
                        k.SetActive(true);
                        s11.Play();
                    }
                    else if (l.name == TG.text){
                        l.SetActive(true);
                        s12.Play();
                    }
                    else if (m.name == TG.text){
                        m.SetActive(true);
                        s13.Play();
                    }
                    else if (n.name == TG.text){
                        n.SetActive(true);
                        s14.Play();
                    }
                    else if (o.name == TG.text){
                        o.SetActive(true);
                        s15.Play();
                    }
                    else if (p.name == TG.text){
                        p.SetActive(true);
                        s16.Play();
                    }
                }
                else if (SetData.ouo.language == 2.ToString()){
                    if (ea.name == TG.text){
                        ea.SetActive(true);
                        es1.Play();
                    }
                    else if (eb.name == TG.text){
                        eb.SetActive(true);
                        es2.Play();
                    }
                    else if (ec.name == TG.text){
                        ec.SetActive(true);
                        es3.Play();
                    }
                    else if (ed.name == TG.text){
                        ed.SetActive(true);
                        es4.Play();
                    }
                    else if (ee.name == TG.text){
                        ee.SetActive(true);
                        es5.Play();
                    }
                    else if (ef.name == TG.text){
                        ef.SetActive(true);
                        es6.Play();
                    }
                    else if (eg.name == TG.text){
                        eg.SetActive(true);
                        es7.Play();
                    }
                    else if (eh.name == TG.text){
                        eh.SetActive(true);
                        es8.Play();
                    }
                    else if (ei.name == TG.text){
                        ei.SetActive(true);
                        es9.Play();
                    }
                    else if (ej.name == TG.text){
                        ej.SetActive(true);
                        es10.Play();
                    }
                    else if (ek.name == TG.text){
                        ek.SetActive(true);
                        es11.Play();
                    }
                    else if (el.name == TG.text){
                        el.SetActive(true);
                        es12.Play();
                    }
                    else if (em.name == TG.text){
                        em.SetActive(true);
                        es13.Play();
                    }
                    else if (en.name == TG.text){
                        en.SetActive(true);
                        es14.Play();
                    }
                    else if (eo.name == TG.text){
                        eo.SetActive(true);
                        es15.Play();
                    }
                    else if (ep.name == TG.text){
                        ep.SetActive(true);
                        es16.Play();
                    }
                }
            }
        }
	}

	public void L2FmuscleObject(){
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
            else if (i.name == TG.text)
            {
                i.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (j.name == TG.text)
            {
                j.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (k.name == TG.text)
            {
                k.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (l.name == TG.text)
            {
                l.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (m.name == TG.text)
            {
                m.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (n.name == TG.text)
            {
                n.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (o.name == TG.text)
            {
                o.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (p.name == TG.text)
            {
                p.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
        }
        else if (SetData.ouo.language == 2.ToString())
        {
            if (ea.name == TG.text)
            {
                ea.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (eb.name == TG.text)
            {
                eb.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ec.name == TG.text)
            {
                ec.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ed.name == TG.text)
            {
                ed.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ee.name == TG.text)
            {
                ee.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ef.name == TG.text)
            {
                ef.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (eg.name == TG.text)
            {
                eg.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (eh.name == TG.text)
            {
                eh.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ei.name == TG.text)
            {
                ei.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ej.name == TG.text)
            {
                ej.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ek.name == TG.text)
            {
                ek.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (el.name == TG.text)
            {
                el.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (em.name == TG.text)
            {
                em.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (en.name == TG.text)
            {
                en.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (eo.name == TG.text)
            {
                eo.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ep.name == TG.text)
            {
                ep.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
        }
	}
}
