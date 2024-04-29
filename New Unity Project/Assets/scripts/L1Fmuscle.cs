using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class L1Fmuscle : MonoBehaviour {
	public static List<string> questionBank;
	public AudioSource s1,s2,s3,s4,s5,s6,s7,es1,es2,es3,es4,es5,es6,es7;
    public Text title, target, FM, SM, L, L1, L2, V, V1,
     V2, V3, V4, M, M1, M2, M3, M4, M5, M6, M7, M8, score, l_AS, v_AS, B, R, MN1,
      MN2, MN3, MN4, MN5, MN6, MN7, BTH;
	public GameObject a,b,c,d,e,f,g,aw,bw,cw,dw,ew,fw,gw;
	public static int r;
    public static float avg_score, max1 = 0, max2 = 0;

    void Start (){
        SetData.wrong_clicks = 0;

        questionBank = new List<string>();
		if (SetData.ouo.language == "1") {
			questionBank.Add ("胸大肌");
			questionBank.Add ("三角肌");
			questionBank.Add ("肱二頭肌");
			questionBank.Add ("腹直肌");
			questionBank.Add ("腹外斜肌");
			questionBank.Add ("內收肌");
			questionBank.Add ("股四頭肌");
        }
		else if (SetData.ouo.language == "2")
        {
            questionBank.Add("pectoralis major");
            questionBank.Add ("deltoid");
			questionBank.Add ("biceps brachii");
			questionBank.Add ("rectus abdominis");
			questionBank.Add ("extermal obliques");
			questionBank.Add ("adductors");
			questionBank.Add ("quadriceps");

            a.name = "pectoralis major";
            b.name = "deltoid";
            c.name = "biceps brachii";
            d.name = "rectus abdominis";
            e.name = "extermal obliques";
            f.name = "adductors";
            g.name = "quadriceps";
            aw.name = "pectoralis major";
            bw.name = "deltoid";
            cw.name = "biceps brachii";
            dw.name = "rectus abdominis";
            ew.name = "extermal obliques";
            fw.name = "adductors";
            gw.name = "quadriceps";
            MN1.text = questionBank[0];
            MN2.text = questionBank[1];
            MN3.text = questionBank[2];
            MN4.text = questionBank[3];
            MN5.text = questionBank[4];
            MN6.text = questionBank[5];
            MN7.text = questionBank[6];
            title.text = "Muscle Memory";
            target.text = "target";
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
            score.text = "score";
            l_AS.text = "Average Score";
            B.text = "begin";
            R.text = "reset";
            BTH.text = "back to home";
        }
	}

    public void L1FmuscleName(){
	    if (questionBank.Count == 0) {
            avg_score = L1Fscore.total_score/7;
            if (SetData.currentlevel == 1)
            {
                SetData.passed_level[0] = 1;
                if (avg_score > max1)
                {
                    max1 = avg_score;
                }
            }
            if (SetData.currentlevel == 2)
            {
                SetData.passed_level[1] = 1;
                if (avg_score > max2)
                {
                    max2 = avg_score;
                }
            }

            v_AS.text = avg_score.ToString("00.0");
            GameObject.Find("EventSystem").SendMessage("maxscore");
            GameObject.Find("EventSystem").SendMessage("show_score_sheet");

            if (avg_score < 75)
            {
                GameObject.Find("EventSystem").GetComponent<WinAndLose>().SendMessage("Lose");
            }
            else if (avg_score >= 75)
            {
                GameObject.Find("EventSystem").GetComponent<WinAndLose>().SendMessage("Win");
            }
        }
        else {
            r = Random.Range (0,questionBank.Count-1);
            target.text = questionBank[r];
            SetData.ouo.answer = target.text;
            if (SetData.currentlevel == 1)
            {
                if (SetData.ouo.language == 1.ToString())
                {
                    if (a.name == target.text)
                    {
                        s1.Play();
                        a.SetActive(true);
                        a.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (b.name == target.text)
                    {
                        s2.Play();
                        b.SetActive(true);
                        b.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (c.name == target.text)
                    {
                        s3.Play();
                        c.SetActive(true);
                        c.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (d.name == target.text)
                    {
                        s4.Play();
                        d.SetActive(true);
                        d.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (e.name == target.text)
                    {
                        s5.Play();
                        e.SetActive(true);
                        e.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (f.name == target.text)
                    {
                        s6.Play();
                        f.SetActive(true);
                        f.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (g.name == target.text)
                    {
                        s7.Play();
                        g.SetActive(true);
                        g.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                }
                else if (SetData.ouo.language == 2.ToString())
                {
                    if (a.name == target.text)
                    {
                        es1.Play();
                        a.SetActive(true);
                        a.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (b.name == target.text)
                    {
                        es2.Play();
                        b.SetActive(true);
                        b.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (c.name == target.text)
                    {
                        es3.Play();
                        c.SetActive(true);
                        c.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (d.name == target.text)
                    {
                        es4.Play();
                        d.SetActive(true);
                        d.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (e.name == target.text)
                    {
                        es5.Play();
                        e.SetActive(true);
                        e.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (f.name == target.text)
                    {
                        es6.Play();
                        f.SetActive(true);
                        f.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (g.name == target.text)
                    {
                        es7.Play();
                        g.SetActive(true);
                        g.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                }
            }
            if (SetData.currentlevel == 2)
            {
                if (SetData.ouo.language == 1.ToString())
                {
                    if (a.name == target.text)
                    {
                        s1.Play();
                        a.SetActive(true);
                    }
                    else if (b.name == target.text)
                    {
                        s2.Play();
                        b.SetActive(true);
                    }
                    else if (c.name == target.text)
                    {
                        s3.Play();
                        c.SetActive(true);
                    }
                    else if (d.name == target.text)
                    {
                        s4.Play();
                        d.SetActive(true);
                    }
                    else if (e.name == target.text)
                    {
                        s5.Play();
                        e.SetActive(true);
                    }
                    else if (f.name == target.text)
                    {
                        s6.Play();
                        f.SetActive(true);
                    }
                    else if (g.name == target.text)
                    {
                        s7.Play();
                        g.SetActive(true);
                    }
                }
                else if (SetData.ouo.language == 2.ToString())
                {
                    if (a.name == target.text)
                    {
                        es1.Play();
                        a.SetActive(true);
                    }
                    else if (b.name == target.text)
                    {
                        es2.Play();
                        b.SetActive(true);
                    }
                    else if (c.name == target.text)
                    {
                        es3.Play();
                        c.SetActive(true);
                    }
                    else if (d.name == target.text)
                    {
                        es4.Play();
                        d.SetActive(true);
                    }
                    else if (e.name == target.text)
                    {
                        es5.Play();
                        e.SetActive(true);

                    }
                    else if (f.name == target.text)
                    {
                        es6.Play();
                        f.SetActive(true);
                    }
                    else if (g.name == target.text)
                    {
                        es7.Play();
                        g.SetActive(true);
                    }
                }
            }
        }
    }

    public void L1FmuscleObject()
    {
        if (a.name == target.text)
        {
            a.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        }
        else if (b.name == target.text)
        {
            b.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        }
        else if (c.name == target.text)
        {
            c.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        }
        else if (d.name == target.text)
        {
            d.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        }
        else if (e.name == target.text)
        {
            e.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        }
        else if (f.name == target.text)
        {
            f.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        }
        else if (g.name == target.text)
        {
            g.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        }
    }
}
