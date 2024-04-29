using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

public class sql : MonoBehaviour {

    public static void transferData()
    {
        /*string sqlServer = "Server=127.0.0.1;Port=3306;Uid=root;Pwd=xue890827;Database=muscle_memory;";
        MySqlConnection conn = new MySqlConnection(sqlServer);

        conn.Open();

        string sqlInsert = @"INSERT INTO muscle (account ,date, language, type, level, view, module, times, position, answer, score)
                                    VALUES ('" + SetData.ouo.account + "', '" + SetData.ouo.date+ "', '"+ SetData.ouo.language + "', '" + SetData.ouo.type + "', '" + SetData.ouo.level + "','" + SetData.ouo.view + "', '" + SetData.ouo.module + "', '" + SetData.ouo.times + "', '" + SetData.ouo.position + "','" + SetData.ouo.answer + "','" + SetData.ouo.score + "');";

        MySqlCommand cmd = new MySqlCommand(sql, conn);
        int index = cmd.ExecuteNonQuery();
        if (index > 0)
            Debug.Log("success");
        else
            Debug.Log(" not success");
        conn.Close();*/
    }
}
