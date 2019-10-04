using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSWord = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;

namespace WordAddImg
{
    public partial class WordAddImg : Form
    {
        public WordAddImg()
        {
            InitializeComponent();
        }
        //选择图片所在文件夹
        private void bt_browser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            //对话框的名字
            dialog.Description = "Please choose the path ";
            string foldPath = "";
            //点击对话框的确定之后执行
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = dialog.SelectedPath;
            }
            tb_FilePath.Text = foldPath;
        }
        //开始执行
        private void bt_Satrt_Click(object sender, EventArgs e)
        {
            tb_FileName.Text = "开始执行，请稍候！"+ Environment.NewLine;
            
            object path;                              //文件路径变量
            MSWord.Application wordApp;                   //Word应用程序变量 
            MSWord.Document wordDoc;                  //Word文档变量

            path = Environment.CurrentDirectory + "\\MyWord_Print.doc";
            wordApp = new MSWord.ApplicationClass(); //初始化
            wordApp.Visible = true;//使文档可见
            //如果已存在，则删除
            if (File.Exists((string)path))
            {
                File.Delete((string)path);
            }
            //由于使用的是COM库，因此有许多变量需要用Missing.Value代替
            Object Nothing = Missing.Value;
            wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);
            #region 页面设置、页眉图片和文字设置，最后跳出页眉设置
            //页面设置
            wordDoc.PageSetup.PaperSize = MSWord.WdPaperSize.wdPaperA4;//设置纸张样式为A4纸
            wordDoc.PageSetup.Orientation = MSWord.WdOrientation.wdOrientPortrait;//排列方式为垂直方向
            wordDoc.PageSetup.TopMargin = 57.0f;
            wordDoc.PageSetup.BottomMargin = 57.0f;
            wordDoc.PageSetup.LeftMargin = 57.0f;
            wordDoc.PageSetup.RightMargin = 57.0f;
            wordDoc.PageSetup.HeaderDistance = 30.0f;//页眉位置
            #endregion
            #region 页码设置并添加页码
            //为当前页添加页码
            MSWord.PageNumbers pns = wordApp.Selection.Sections[1].Headers[MSWord.WdHeaderFooterIndex.wdHeaderFooterEvenPages].PageNumbers;//获取当前页的号码
            pns.NumberStyle = MSWord.WdPageNumberStyle.wdPageNumberStyleNumberInDash;//设置页码的风格，是Dash形还是圆形的
            pns.HeadingLevelForChapter = 0;
            pns.IncludeChapterNumber = false;
            pns.RestartNumberingAtSection = false;
            pns.StartingNumber = 0; //开始页页码？
            object pagenmbetal = MSWord.WdPageNumberAlignment.wdAlignPageNumberCenter;//将号码设置在中间
            object first = true;
            wordApp.Selection.Sections[1].Footers[MSWord.WdHeaderFooterIndex.wdHeaderFooterEvenPages].PageNumbers.Add(ref pagenmbetal, ref first);
            #endregion
            object unite = MSWord.WdUnits.wdStory;
            #region 添加表格、填充数据、设置表格行列宽高、合并单元格、添加表头斜线、给单元格添加图片
            wordDoc.Content.InsertAfter("\n");//这一句与下一句的顺序不能颠倒，原因还没搞透
            wordApp.Selection.EndKey(ref unite, ref Nothing); //将光标移动到文档末尾
            wordApp.Selection.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphLeft;

            //遍历文件夹下所有jpg
            String path_img = tb_FilePath.Text;
            String FileEx = label_FileEx.Text;
            var files = Directory.GetFiles(path_img, FileEx);
            List<string> testList = new List<string>();
            foreach (var file in files)
                testList.Add(file);
            //设置表格的行数和列数
            int testList_Count = testList.Count;
            int tableRow = testList_Count;
            int tableColumn = 2;

            //定义一个Word中的表格对象
            MSWord.Table table = wordDoc.Tables.Add(wordApp.Selection.Range,
            tableRow, tableColumn, ref Nothing, ref Nothing);
            //默认创建的表格没有边框，这里修改其属性，使得创建的表格带有边框 
            table.Borders.Enable = 1;//这个值可以设置得很大，例如5、13等等
            //添加行
            table.Rows.Add(ref Nothing);
            table.Rows[tableRow + 1].Height = 35;//设置新增加的这行表格的高度
            //向新添加的行的单元格中添加图片
            object LinkToFile = false;
            object SaveWithDocument = true;
            object Anchor;
            for (int i = 0; i < testList_Count; i++)
            {
                int img_num = i + 1;
                tb_FileName.Text += "正在处理第"+ img_num + "张图片。"+ Environment.NewLine;
                string FileName = testList[i];
                //获取没有扩展名的文件名存入List::FileNameList
                string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(FileName);// 没有
                if (i % 2 == 0)
                {
                    Anchor = table.Cell(i + 1, 1).Range;//选中要添加图片的单元格
                    wordDoc.Application.ActiveDocument.InlineShapes.AddPicture(FileName, ref LinkToFile, ref SaveWithDocument, ref Anchor);
                    table.Cell(i+2, 1).Range.Text = fileNameWithoutExtension;//填充每列的标题
                }
                else
                {
                    Anchor = table.Cell(i, 2).Range;//选中要添加图片的单元格
                    wordDoc.Application.ActiveDocument.InlineShapes.AddPicture(FileName, ref LinkToFile, ref SaveWithDocument, ref Anchor);
                    table.Cell(i+1, 2).Range.Text = fileNameWithoutExtension;//填充每列的标题
                }
            }
            

            //设置table样式
            table.Rows.HeightRule = MSWord.WdRowHeightRule.wdRowHeightAtLeast;//高度规则是：行高有最低值下限？
            table.Rows.Height = wordApp.CentimetersToPoints(float.Parse("0.8"));// 

            table.Range.Font.Size = 10.5F;
            table.Range.Font.Bold = 0;

            table.Range.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphCenter;//表格文本居中
            table.Range.Cells.VerticalAlignment = MSWord.WdCellVerticalAlignment.wdCellAlignVerticalBottom;//文本垂直贴到底部
            //设置table边框样式
            table.Borders.OutsideLineStyle = MSWord.WdLineStyle.wdLineStyleDouble;//表格外框是双线
            table.Borders.InsideLineStyle = MSWord.WdLineStyle.wdLineStyleSingle;//表格内框是单线

            table.Rows[1].Range.Font.Bold = 1;//加粗
            table.Rows[1].Range.Font.Size = 12F;
            table.Cell(1, 1).Range.Font.Size = 10.5F;
            wordApp.Selection.Cells.Height = 30;//所有单元格的高度

            //除第一行外，其他行的行高都设置为20
            for (int i = 2; i <= tableRow; i++)
            {
                table.Rows[i].Height = 20;
            }
            table.Columns[1].Width = 50;//将第 1列宽度设置为50

            //将其他列的宽度都设置为75
            for (int i = 2; i <= tableColumn; i++)
            {
                table.Columns[i].Width = 50;
            }
            #endregion
            wordApp.Selection.EndKey(ref unite, ref Nothing); //将光标移动到文档末尾
            wordDoc.Content.InsertAfter("\n");
            //WdSaveFormat为Word 2003文档的保存格式
            object format = MSWord.WdSaveFormat.wdFormatDocument;// office 2007就是wdFormatDocumentDefault
            //将wordDoc文档对象的内容保存为DOCX文档
            wordDoc.SaveAs(ref path, ref format, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
            //关闭wordDoc文档对象
            //看是不是要打印
            //wordDoc.PrintOut();
            wordDoc.Close(ref Nothing, ref Nothing, ref Nothing);
            //关闭wordApp组件对象
            wordApp.Quit(ref Nothing, ref Nothing, ref Nothing);
            tb_FileName.Text += "全部执行完毕";
        }

        private void cb_FileEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label_FileEx.Text = cb_FileEx.Text;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
