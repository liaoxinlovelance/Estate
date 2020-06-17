using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Data;  
using System.Drawing;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
using System.Windows.Forms;  
using Newtonsoft.Json;//json解析用  
using System.IO;  
using System.Net;
using System.Drawing.Drawing2D;


namespace 综合项目
{
    public partial class jiqiren : Form
    {
        //const String KEY = "6548d8cdc2944c0482bc9b10e2690d27"; //这里是注册时得到的key  

        public jiqiren()
        {
            InitializeComponent();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            // Scrolls the contents of the control to the current caret position.
            richTextBox1.ScrollToCaret();
        }
        private void btfasong_Click(object sender, EventArgs e)
        {
            String input = textBox1.Text;
            string url = "http://www.tuling123.com/openapi/api?key=6548d8cdc2944c0482bc9b10e2690d27&info=" + input;

            /* 清空输入框 */
            textBox1.Text = "";
            /* 将输入内容放入聊天记录窗口中 */
            richTextBox1.AppendText("You: " + input + "\n");

            Encoding encoding = Encoding.GetEncoding("utf-8");

            String data = HttpGet(url, encoding);

            JsonReader reader = new JsonTextReader(new StringReader(data));

            while (reader.Read())
            {
                //tbxHistory.AppendText(reader.TokenType + "\t\t" + reader.ValueType + "\t\t" + reader.Value + "\n");  
                if (reader.TokenType == JsonToken.PropertyName
                    && reader.ValueType == Type.GetType("System.String")
                    && Convert.ToString(reader.Value) == "code")
                {
                    /* 如果当前Value是code，读取下一条，查看code的值 */
                    reader.Read();
                    switch (Convert.ToInt32(reader.Value))
                    {
                        case 100000:
                            /* 返回码为文本类数据 */
                            reader.Read();
                            reader.Read();
                            richTextBox1.AppendText("Robot: " + reader.Value + "\n");
                            break;
                        default:
                            break;
                    }
                }
            }
        }


        public static string HttpGet(string url, Encoding encoding)
        {
            string data = "";
            try
            {
                WebRequest request; //使用url发出请求的类  
                request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;   //使用默认的身份验证  
                request.Timeout = 10000;    //设定超时  
                WebResponse response;   //提供响应的类  
                response = request.GetResponse();
                data = new StreamReader(response.GetResponseStream(), encoding).ReadToEnd();    //获取数据  
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return data;
        }

        private void jiqiren_Load(object sender, EventArgs e)
        {

        }
    }
}