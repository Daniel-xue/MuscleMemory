using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CurrentLevel : MonoBehaviour {
	public void L1_F_1(){
		SceneManager.LoadScene ("L1_F");
        SetData.currentlevel = 1;
        SetData.ouo.level = "1";
        SetData.ouo.view= "1";
        SetData.ouo.module = "1";
    }
	public void L1_F_2(){
		SceneManager.LoadScene ("L1_F");
        SetData.currentlevel = 2;
        SetData.ouo.level = "1";
        SetData.ouo.view = "1";
        SetData.ouo.module = "2";
    }
	public void L1_B_1(){
		SceneManager.LoadScene ("L1_B");
        SetData.currentlevel = 3;
        SetData.ouo.level = "1";
        SetData.ouo.view = "2";
        SetData.ouo.module = "1";
    }
	public void L1_B_2(){
		SceneManager.LoadScene ("L1_B");
        SetData.currentlevel = 4;
        SetData.ouo.level = "1";
        SetData.ouo.view = "2";
        SetData.ouo.module = "2";
    }
	public void L2_F_1(){
		SceneManager.LoadScene ("L2_F");
        SetData.currentlevel = 5;
        SetData.ouo.level = "2";
        SetData.ouo.view = "1";
        SetData.ouo.module = "1";
    }
	public void L2_F_2(){
		SceneManager.LoadScene ("L2_F");
        SetData.currentlevel = 6;
        SetData.ouo.level = "2";
        SetData.ouo.view = "1";
        SetData.ouo.module = "2";
    }
	public void L2_B_1(){
		SceneManager.LoadScene ("L2_B");
        SetData.currentlevel = 7;
        SetData.ouo.level = "2";
        SetData.ouo.view = "2";
        SetData.ouo.module = "1";
    }
	public void L2_B_2(){
		SceneManager.LoadScene ("L2_B");
        SetData.currentlevel = 8;
        SetData.ouo.level = "2";
        SetData.ouo.view = "2";
        SetData.ouo.module = "2";
    }
}
