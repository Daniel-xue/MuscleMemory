using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetData : MonoBehaviour
{
    //傳遞給資料庫的值
    public static class ouo
    {
        public static string account;  //遊戲次數
        public static string date;  //日期
        public static string language="1";  //語言版本
        public static string type="2";  //代表muscle
        public static string level;  //level
        public static string view;  //正反面
        public static string module;  //scan或poke
        public static int times=0;  //
        public static string position;  //選擇的答案
        public static string answer="";  //該題正確答案
        public static float score;  //得分
    }

    public static int currentlevel=1;
    public static int LastFinalLevel=1;
    public static int wrong_clicks = 0;
    public static int[] passed_level = { 0, 0, 0, 0, 0, 0, 0, 0 };
}
