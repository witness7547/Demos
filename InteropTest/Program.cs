using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteropTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateWordDocument();
        }

        public static void CreateWordDocument()
        {
            // 启动Word并使Word可见
            Application wordApp = new Application() { Visible = true };

            // 新建Word文档
            wordApp.Documents.Add();
            Document wordDoc = wordApp.ActiveDocument;
            Paragraph para = wordDoc.Paragraphs.Add();
            para.Range.Text = "欢迎你，进入Learning Hard博客";

            // 保存文档
            object filename = @"D:\learninghard.doc";
            wordDoc.SaveAs2(filename);

            // 关闭Word
            wordDoc.Close();
            wordApp.Application.Quit();
        }
    }
}
