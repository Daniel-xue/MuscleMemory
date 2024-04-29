using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

public class sign_in : MonoBehaviour
{
    public Text account, password, message;
    string sqlServer = "Server=127.0.0.1;Port=3306;Uid=root;Pwd=xue890827;Database=muscle_memory;";

    // 當點擊登入按鈕
    public void Login()
    {
        SceneManager.LoadScene("L1_F");
        SetData.currentlevel = 1;
        SetData.ouo.level = "1";
        SetData.ouo.view = "1";
        SetData.ouo.module = "1";
        /*
        MySqlConnection conn = new MySqlConnection(sqlServer);
        try
        {
            conn.Open();
            Debug.Log("------連接成功------");

            // 透過windows驗證建立本機資料庫連線
            string queryString = @"SELECT * FROM member WHERE account=@paral1 and password=@paral2" ;
            MySqlCommand comd = new MySqlCommand(queryString, conn);

            comd.Parameters.AddWithValue("paral1", account.text);
            comd.Parameters.AddWithValue("paral2", password.text);

            MySqlDataReader reader = comd.ExecuteReader();
            if (reader.Read())
            {
                message.text = "登錄成功!";
                Debug.Log("------用户存在，登錄成功！------");
                SceneManager.LoadScene("Language");
            }
            else
            {
                message.text = "用户不存在，請註冊。或請檢查用户和密碼！";
                Debug.Log("------用户不存在，請註冊。或請檢查用户名和密碼！------");
            }
        }
        catch (System.Exception e)
        {

            Debug.Log(e.Message);
        }
        finally
        {
            conn.Close();
        }*/
    }
    // 當點擊註冊按鈕
    public void Register()
    {
        MySqlConnection conn = new MySqlConnection(sqlServer);
        try
        {
            conn.Open();
            Debug.Log("------連接成功------");
            string sqlSelect = @"SELECT * FROM member WHERE account=@paral1 and password=@paral2" ;
            MySqlCommand comd = new MySqlCommand(sqlSelect, conn);

            comd.Parameters.AddWithValue("paral1", account.text);
            comd.Parameters.AddWithValue("paral2", password.text);

            MySqlDataReader reader = comd.ExecuteReader();
            if (reader.Read())
            {
                message.text = "用户已存在，請重新輸入！";
            }
            else
            {
                reader.Close();
                string sqlInsert = "insert into member(account,password) values('" + account.text + "','" + password.text + "')";
                MySqlCommand comd2 = new MySqlCommand(sqlInsert, conn);
                int resule = comd2.ExecuteNonQuery();
                message.text = "註冊成功，請進行登入！";
            }
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message);
        }
        finally
        {
            conn.Close();
        }
    }
}