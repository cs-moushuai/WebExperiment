using System;
using MySql.Data.MySqlClient;
using System.Data;
//using System.Data.SqlClient;

//Console.WriteLine("Hello, World!");
/*
double[] arr = {5.2, 4.1, 8.2, 16.6};
Caculator cac = new Caculator(arr, arr.Length);
Console.WriteLine("最大值："+cac.GetMax());
Console.WriteLine("最小值："+cac.GetMin());
Console.WriteLine("平均值："+cac.GetAverage());*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("雇员信息：");
        Employee ep = new Employee(1, "李芳", "女", "北京", "1663", "1642@163.com");
        ep.Print();
        ep.Email = "123@qq.com";
        ep.Print();


        Console.WriteLine("图形调用：");
        Square t = new Square(4);
        Console.WriteLine("4*4正方形面积：" + t.GetArea());
        Shape[] p = new Shape[2];
        p[0] = new Square(3);
        p[1] = new Circle(3);
        Console.WriteLine("3*3正方形面积：" + p[0].GetArea());
        Console.WriteLine("半径3的圆面积：" + p[1].GetArea());

        /*
        // SQL
        string connInfo = "Server=localhost;Uid=root;Database=StuData;Port=3306;";
        SqlConnection conn = new SqlConnection(connInfo);
        string sqlChange = "UPDATE Score SET stu_Score=93.5 WHERE sub_ID = (SELECT subID FROM Subjects WHERE subName = \"数据结构\") AND stu_ID = (SELECT stu_ID FROM Students WHERE stu_Name = \"张林\");";
        SqlCommand comm = new SqlCommand(sqlChange, conn);
        conn.Open();
        comm.ExecuteNonQuery();
        Console.WriteLine("\n张林同学分数更新成功\n");

        string sqlQuery = "SELECT stu_Score FROM Score, Subjects WHERE subName=\"数据结构\" and Subjects.subID=Score.sub_ID;";
        SqlDataAdapter adr = new SqlDataAdapter(sqlQuery, conn);
        adr.SelectCommand.CommandType = CommandType.Text;
        DataTable dt = new DataTable();
        adr.Fill(dt);

        double[] score = new double[dt.Rows.Count];
        for (int i = 0; i < dt.Rows.Count; i++) {
            score[i] = (double)dt.Rows[i]["stu_Score"];           
        }
        Caculator cac = new Caculator(score, score.Length);
        Console.WriteLine("数据结构分数表");
        Console.WriteLine("最大值："+cac.GetMax());
        Console.WriteLine("最小值："+cac.GetMin());
        Console.WriteLine("平均值："+cac.GetAverage());
        conn.Close();
        */

        // Mysql
        string connInfo = "Server=localhost;Uid=root;Database=StuData;Port=3306;";
        MySqlConnection conn = new MySqlConnection(connInfo);
        string sqlChange = "UPDATE Score SET stu_Score=93.5 WHERE sub_ID = (SELECT subID FROM Subjects WHERE subName = \"数据结构\") AND stu_ID = (SELECT stu_ID FROM Students WHERE stu_Name = \"张林\");";
        MySqlCommand comm = new MySqlCommand(sqlChange, conn);
        conn.Open();
        comm.ExecuteNonQuery();
        Console.WriteLine("\n张林同学分数更新成功\n");

        string sqlQuery = "SELECT stu_Score FROM Score, Subjects WHERE subName=\"数据结构\" and Subjects.subID=Score.sub_ID;";
        MySqlDataAdapter adr = new MySqlDataAdapter(sqlQuery, conn);
        // adr.SelectCommand.CommandType = CommandType.Text;
        DataTable dt = new DataTable();
        adr.Fill(dt);
        conn.Close();

        double[] score = new double[dt.Rows.Count];
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            score[i] = (double)dt.Rows[i]["stu_Score"];
        }
        Caculator cac = new Caculator(score, score.Length);
        Console.WriteLine("数据结构分数表");
        Console.WriteLine("最大值：" + cac.GetMax());
        Console.WriteLine("最小值：" + cac.GetMin());
        Console.WriteLine("平均值：" + cac.GetAverage() + "\n");

        // 额外的栈题目
        Console.WriteLine("模拟栈");
        StackTp st = new StackTp();
        st.Push(6);
        Console.WriteLine(st.Top());
    }
}