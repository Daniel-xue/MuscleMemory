using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L2Bmuscle : MonoBehaviour {
    public static List<string> questionBank;
    public Text title, TG, FM, SM, L, L1, L2, V, V1, V2, V3, V4, M, M1, M2, M3, M4, M5, M6,
     M7, M8, S, l_AS, v_AS, B, R, MN1, MN2, MN3, MN4, MN5, MN6, MN7, MN8,
      MN9, MN10, MN11, MN12, MN13, MN14, MN15,BTH;
    public AudioSource bgMusic;
	public AudioSource m1,m2,m3,m4,m5,m6,m7,m8,m9,m10,m11,m12,m13,m14, m15,em1,em2, em3, em4, em5, em6, em7, em8, em9, em10, em11, em12, em13, em14, em15;
    public GameObject a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15;
    public GameObject ea1, ea2, ea3, ea4, ea5, ea6, ea7, ea8, ea9, ea10, ea11, ea12, ea13, ea14, ea15;
    public GameObject a1w, a2w, a3w, a4w, a5w, a6w, a7w, a8w, a9w, a10w, a11w, a12w, a13w, a14w, a15w;
    public static int r;
    public Button reset;
    public Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8;
    public static float avg_score, max1 = 0, max2 = 0;
    // Use this for initialization
    void Start() {
        SetData.wrong_clicks = 0;

        questionBank = new List<string>();
        if (SetData.ouo.language == "1"){
            questionBank.Add("斜方肌");
            questionBank.Add("三角肌");
            questionBank.Add("棘下肌");
            questionBank.Add("大圓肌");
            questionBank.Add("闊背肌");
            questionBank.Add("豎脊肌");
            questionBank.Add("肱三頭肌");
            questionBank.Add("肱橈肌");
            questionBank.Add("腕屈肌");
            questionBank.Add("臀大肌");
            questionBank.Add("內收肌");
            questionBank.Add("股二頭肌");
            questionBank.Add("半膜肌");
            questionBank.Add("半腱肌");
            questionBank.Add("腓腸肌");
        }
        else if (SetData.ouo.language == "2"){
            questionBank.Add("trapezius");
            questionBank.Add("deltoid");
            questionBank.Add("infraspinatus");
            questionBank.Add("teres major");
            questionBank.Add("latissimus dorsi");
            questionBank.Add("erector spinae");
            questionBank.Add("triceps brachii");
            questionBank.Add("brachioradialis");
            questionBank.Add("wrist extensors");
            questionBank.Add("gluteus maximus");
            questionBank.Add("adductors");
            questionBank.Add("biceps femoris");
            questionBank.Add("semitendinosus");
            questionBank.Add("semimembranosus");
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

            a1w.name = "trapezius";
            a2w.name = "deltoid";
            a3w.name = "infraspinatus";
            a4w.name = "teres major";
            a5w.name = "latissimus dorsi";
            a6w.name = "erector spinae";
            a7w.name = "triceps brachii";
            a8w.name = "brachioradialis";
            a9w.name = "wrist extensors";
            a10w.name = "gluteus maximus";
            a11w.name = "adductors";
            a12w.name = "biceps femoris";
            a13w.name = "semitendinosus";
            a14w.name = "semimembranosus";
            a15w.name = "gastrocnemius";
        }
    }
    //
    public void L2BmuscleName() {
        if (questionBank.Count == 0) {
            avg_score = L2Bscore.total_score/15;
            if (SetData.currentlevel == 7){
                if (avg_score > max1){
                    max1 = avg_score;
                }
            }
            if (SetData.currentlevel == 8){
                if (avg_score > max2){
                    max2 = avg_score;
                }
            }

            v_AS.text = avg_score.ToString("00.0");
            GameObject.Find("EventSystem").SendMessage("maxscore");
            if (avg_score < 75) {
                GameObject.Find("EventSystem").SendMessage("show_score_sheet");
                GameObject.Find("EventSystem").GetComponent<WinAndLose>().SendMessage("Lose");
            }
            else if (avg_score >= 75) {
                if (SetData.currentlevel == 7) {
                    btn1.interactable = true;
                    btn2.interactable = true;
                    btn3.interactable = true;
                    btn4.interactable = true;
                    btn5.interactable = true;
                    btn6.interactable = true;
                    btn7.interactable = true;
					btn8.interactable = true;
                }
                else if (SetData.currentlevel == 8) {
                    btn1.interactable = true;
                    btn2.interactable = true;
                    btn3.interactable = true;
                    btn4.interactable = true;
                    btn5.interactable = true;
                    btn6.interactable = true;
                    btn7.interactable = true;
                    btn8.interactable = true;
                }
                GameObject.Find("EventSystem").SendMessage("show_score_sheet");
                GameObject.Find("EventSystem").GetComponent<WinAndLose>().SendMessage("Win");
            }
        }
        else {
            r = Random.Range(0, questionBank.Count - 1);
            TG.text = questionBank[r];
            SetData.ouo.answer = TG.text;
            if (SetData.currentlevel == 7) {
                if (SetData.ouo.language == 1.ToString()){
                    if (a1.name == TG.text){
                        m1.Play();
                        a1.SetActive(true);
                        a1.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a2.name == TG.text){
                        m2.Play();
                        a2.SetActive(true);
                        a2.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a3.name == TG.text){
                        m3.Play();
                        a3.SetActive(true);
                        a3.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a4.name == TG.text){
                        m4.Play();
                        a4.SetActive(true);
                        a4.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a5.name == TG.text){
                        m5.Play();
                        a5.SetActive(true);
                        a5.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a6.name == TG.text){
                        m6.Play();
                        a6.SetActive(true);
                        a6.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a7.name == TG.text){
                        m7.Play();
                        a7.SetActive(true);
                        a7.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a8.name == TG.text){
                        m8.Play();
                        a8.SetActive(true);
                        a8.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a9.name == TG.text){
                        m9.Play();
                        a9.SetActive(true);
                        a9.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a10.name == TG.text){
                        m10.Play();
                        a10.SetActive(true);
                        a10.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a11.name == TG.text){
                        m11.Play();
                        a11.SetActive(true);
                        a11.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a12.name == TG.text){
                        m12.Play();
                        a12.SetActive(true);
                        a12.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a13.name == TG.text){
                        m13.Play();
                        a13.SetActive(true);
                        a13.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a14.name == TG.text){
                        m14.Play();
                        a14.SetActive(true);
                        a14.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (a15.name == TG.text){
                        m15.Play();
                        a15.SetActive(true);
                        a15.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                }
                else if (SetData.ouo.language == 2.ToString()){
                    if (ea1.name == TG.text){
                        em1.Play();
                        ea1.SetActive(true);
                        ea1.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea2.name == TG.text){
                        em2.Play();
                        ea2.SetActive(true);
                        ea2.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea3.name == TG.text){
                       em3.Play();
                        ea3.SetActive(true);
                        ea3.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea4.name == TG.text){
                        em4.Play();
                        ea4.SetActive(true);
                        ea4.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea5.name == TG.text){
                        em5.Play();
                        ea5.SetActive(true);
                        ea5.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea6.name == TG.text){
                        em6.Play();
                        ea6.SetActive(true);
                        ea6.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea7.name == TG.text){
                        em7.Play();
                        ea7.SetActive(true);
                        ea7.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea8.name == TG.text){
                        em8.Play();
                        ea8.SetActive(true);
                        ea8.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea9.name == TG.text){
                        em9.Play();
                        ea9.SetActive(true);
                        ea9.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea10.name == TG.text){
                        em10.Play();
                        ea10.SetActive(true);
                        ea10.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea11.name == TG.text){
                        em11.Play();
                        ea11.SetActive(true);
                        ea11.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea12.name == TG.text){
                        em12.Play();
                        ea12.SetActive(true);
                        ea12.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea13.name == TG.text){
                        em13.Play();
                        ea13.SetActive(true);
                        ea13.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea14.name == TG.text){
                        em14.Play();
                        ea14.SetActive(true);
                        ea14.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                    else if (ea15.name == TG.text){
                        em15.Play();
                        ea15.SetActive(true);
                        ea15.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                    }
                }
            }
            else if (SetData.currentlevel == 8){
                if (SetData.ouo.language == 1.ToString()){
                    if (a1.name == TG.text){
                        m1.Play();
                        a1.SetActive(true);
                    }
                    else if (a2.name == TG.text){
                        m2.Play();
                        a2.SetActive(true);
                    }
                    else if (a3.name == TG.text){
                        m3.Play();
                        a3.SetActive(true);
                    }
                    else if (a4.name == TG.text){
                        m4.Play();
                        a4.SetActive(true);
                    }
                    else if (a5.name == TG.text){
                        m5.Play();
                        a5.SetActive(true);
                    }
                    else if (a6.name == TG.text){
                        m6.Play();
                        a6.SetActive(true);
                    }
                    else if (a7.name == TG.text){
                        m7.Play();
                        a7.SetActive(true);
                    }
                    else if (a8.name == TG.text){
                        m8.Play();
                        a8.SetActive(true);
                    }
                    else if (a9.name == TG.text){
                        m9.Play();
                        a9.SetActive(true);
                    }
                    else if (a10.name == TG.text){
                        m10.Play();
                        a10.SetActive(true);
                    }
                    else if (a11.name == TG.text){
                        m11.Play();
                        a11.SetActive(true);
                    }
                    else if (a12.name == TG.text){
                        m12.Play();
                        a12.SetActive(true);
                    }
                    else if (a13.name == TG.text){
                        m13.Play();
                        a13.SetActive(true);
                    }
                    else if (a14.name == TG.text){
                        m14.Play();
                        a14.SetActive(true);
                    }
                    else if (a15.name == TG.text){
                        m15.Play();
                        a15.SetActive(true);
                    }
                }
                else if (SetData.ouo.language == 2.ToString()){
                    if (ea1.name == TG.text){
                        em1.Play();
                        ea1.SetActive(true);
                    }
                    else if (ea2.name == TG.text){
                        em2.Play();
                        ea2.SetActive(true);
                    }
                    else if (ea3.name == TG.text){
                        em3.Play();
                        ea3.SetActive(true);
                    }
                    else if (ea4.name == TG.text){
                        em4.Play();
                        ea4.SetActive(true);
                    }
                    else if (ea5.name == TG.text){
                        em5.Play();
                        ea5.SetActive(true);
                    }
                    else if (ea6.name == TG.text){
                        em6.Play();
                        ea6.SetActive(true);
                    }
                    else if (ea7.name == TG.text){
                        em7.Play();
                        ea7.SetActive(true);
                    }
                    else if (ea8.name == TG.text){
                        em8.Play();
                        ea8.SetActive(true);
                    }
                    else if (ea9.name == TG.text){
                        em9.Play();
                        ea9.SetActive(true);
                    }
                    else if (ea10.name == TG.text){
                        em10.Play();
                        ea10.SetActive(true);
                    }
                    else if (ea11.name == TG.text){
                        em11.Play();
                        ea11.SetActive(true);
                    }
                    else if (ea12.name == TG.text){
                        em12.Play();
                        ea12.SetActive(true);
                    }
                    else if (ea13.name == TG.text){
                        em13.Play();
                        ea13.SetActive(true);
                    }
                    else if (ea14.name == TG.text){
                        em14.Play();
                        ea14.SetActive(true);
                    }
                    else if (ea15.name == TG.text){
                        em15.Play();
                        ea15.SetActive(true);
                    }
                }
            }
        }
    }

    public void L2BmuscleObject() {
        if (SetData.ouo.language == 1.ToString()){
            if (a1.name == TG.text)
            {
                a1.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a2.name == TG.text)
            {
                a2.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a3.name == TG.text)
            {
                a3.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a4.name == TG.text)
            {
                a4.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a5.name == TG.text)
            {
                a5.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a6.name == TG.text)
            {
                a6.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a7.name == TG.text)
            {
                a7.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a8.name == TG.text)
            {
                a8.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a9.name == TG.text)
            {
                a9.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a10.name == TG.text)
            {
                a10.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a11.name == TG.text)
            {
                a11.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a12.name == TG.text)
            {
                a12.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a13.name == TG.text)
            {
                a13.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a14.name == TG.text)
            {
                a14.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (a15.name == TG.text)
            {
                a15.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
        }
        else if (SetData.ouo.language == 2.ToString()){
            if (ea1.name == TG.text)
            {
                ea1.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea2.name == TG.text)
            {
                ea2.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea3.name == TG.text)
            {
                ea3.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea4.name == TG.text)
            {
                ea4.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea5.name == TG.text)
            {
                ea5.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea6.name == TG.text)
            {
                ea6.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea7.name == TG.text)
            {
                ea7.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea8.name == TG.text)
            {
                ea8.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea9.name == TG.text)
            {
                ea9.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea10.name == TG.text)
            {
                ea10.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea11.name == TG.text)
            {
                ea11.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea12.name == TG.text)
            {
                ea12.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea13.name == TG.text)
            {
                ea13.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea14.name == TG.text)
            {
                ea14.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
            else if (ea15.name == TG.text)
            {
                ea15.gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            }
        }
    }
}


