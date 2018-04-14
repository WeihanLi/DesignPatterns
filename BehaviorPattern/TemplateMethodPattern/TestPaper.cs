using System;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 金庸小说考试试题
    /// </summary>
    internal class TestPaper
    {
        protected string StudentName { get; set; }

        public void TestResult()
        {
            Console.WriteLine($"学生 {StudentName} 的试卷：");
            TestQuestion1();
            TestQuestion2();
            TestQuestion3();
            Console.WriteLine();
        }

        private void TestQuestion1()
        {
            Console.WriteLine("杨过得到后来给了郭靖，炼成倚天剑、屠龙刀的玄铁可能是 [ ]\r\na.球磨铸铁 b.马口铁 c.高速合金钢 d.碳素纤维 ");
            Console.WriteLine($"答案：{Answer1()}");
        }

        private void TestQuestion2()
        {
            Console.WriteLine("杨过、程英、陆无双铲除了情花，造成 [ ]\r\na.使得这种植物不再害人 b.使一种珍稀物种灭绝了 c. 破坏了那个生物圈的生态平衡 d.造成该地区的沙漠化");
            Console.WriteLine($"答案：{Answer2()}");
        }

        private void TestQuestion3()
        {
            Console.WriteLine("蓝凤凰致使华山师徒、桃谷六仙呕吐不止，如果你是大夫，会给他们开什么药 [ ]\r\na.阿司匹林 b.牛黄解毒片 c.黄连 d.让他们喝生牛奶 e.以上都不对");
            Console.WriteLine($"答案：{Answer3()}");
        }

        protected virtual string Answer1()
        {
            return "";
        }

        protected virtual string Answer2()
        {
            return "";
        }

        protected virtual string Answer3()
        {
            return "";
        }
    }

    internal class TestPaperA : TestPaper
    {
        public TestPaperA()
        {
            StudentName = "路人甲";
        }

        protected override string Answer1()
        {
            return "b";
        }

        protected override string Answer2()
        {
            return "c";
        }

        protected override string Answer3()
        {
            return "a";
        }
    }

    internal class TestPaperB : TestPaper
    {
        public TestPaperB()
        {
            StudentName = "吃泡面乙";
        }

        protected override string Answer1()
        {
            return "c";
        }

        protected override string Answer2()
        {
            return "b";
        }

        protected override string Answer3()
        {
            return "a";
        }
    }
}
