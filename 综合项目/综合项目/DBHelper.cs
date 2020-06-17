using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace 综合项目
{
   public  class DBHelper
    {//获取连接字符串
       public static string constr = "Data Source=.;Initial Catalog=shenhaizhadan;Integrated Security=True";
       #region 老版的增删改查
        
        //查询功能
        public static DataTable Select(string sql)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        //增删改功能
        public static bool Execute(string sql)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            int count = cmd.ExecuteNonQuery(); 
            con.Close();
            return count > 0;
        }
       //聚合函数应运
        public static object ExecuteScalar(string sql)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            object result = cmd.ExecuteScalar();
            con.Close();
            return result ;
        }
       #endregion
        #region 存储过程的增删改查(廖鑫篇)
       
        /// <summary>查询
        /// 执行查询操作
        /// </summary>
        /// <param name="proc">存储过程名称</param>
        /// <param name="values">参数数组</param>
        /// <returns>数据表格</returns>
        public static DataTable SelectPrc(string proc,params SqlParameter[] values) {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(proc,conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(values);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            conn.Close();
            return dt;
        }
        /// <summary>
        /// 执行增删改操作
        /// </summary>
        /// <param name="proc">存储过程名称</param>
        /// <param name="values">参数数组</param>
        /// <returns>是否执行成功</returns>
        public static bool ExcutePrc(string proc, params SqlParameter[] values)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(proc, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(values);
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count > 0;
        }
        #endregion 
        #region 存储过程的增删改查(刘祖明篇)
        //存储过程实现查询
        public static DataTable Se(string proc, params SqlParameter[] value)
        {
            SqlConnection con = new SqlConnection(constr);

            con.Open();
            SqlCommand cmd = new SqlCommand(proc, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(value);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            con.Close();
            return dt;

        }
        //存储过程实现增删改
        public static bool Ex(string proc, params SqlParameter[] value)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand(proc, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(value);
            int count = cmd.ExecuteNonQuery();
            con.Close();
            return count > 0;


        }
        #endregion
        #region 存储过程周文韬篇
     
       /// <summary>
       /// 使用存储过程执行查询
       /// </summary>
       /// <param name="sql">存储过程名</param>
       /// <returns>DataTable对象</returns>
       /// //不含参数都查询
       public static DataTable GetDataTable(string sql)
       {
           SqlConnection con = new SqlConnection(constr);
           SqlCommand cmd = new SqlCommand(sql, con);
           cmd.CommandType = CommandType.StoredProcedure;
           SqlDataAdapter adapter = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
           adapter.Fill(dt);
           return dt;
       }
       /// <summary>
       /// 使用含参数存储过程执行查询
       /// </summary>
       /// <param name="sql">存储过程名</param>
       /// <returns>DataTable对象</returns>
       //含参数的查询
       public static DataTable Select(string sql, params SqlParameter[] values)
       {
           SqlConnection con = new SqlConnection(constr);
           SqlCommand cmd = new SqlCommand(sql, con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddRange(values);
           SqlDataAdapter adapter = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
           adapter.Fill(dt);
           return dt;
       }
       /// <summary>
       /// 使用存储过程实现增删改
       /// </summary>
       /// <param name="sql">存储过程名</param>
       /// <param name="values">存储过程参数</param>
       /// <returns>数据库信息数量</returns>
       public static bool ExecutenonQuery(string sql, params SqlParameter[] values)
       {
           SqlConnection con = new SqlConnection(constr);
           con.Open();
           SqlCommand cmd = new SqlCommand(sql, con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddRange(values);
           int count = cmd.ExecuteNonQuery();
           con.Close();
           return count > 0;

       }
    

        #endregion
    }
}
