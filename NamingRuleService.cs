using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ChiayiCultureBureauIMS.Service.DataBase
{
    public class NamingRuleService
    {
        /// <summary>
        /// 註解作業
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public int TestFunction(int index)
        {
            //switch (index)    //good
            //{
            //    case 1:
            //        DoTrue();
            //        break;
            //    default:
            //        DoFalse();
            //        break;
            //}

            switch (index)  //bad 前置大括號〝{〞與後置大括號〝}〞皆單獨置於一行。
            {
                case 1: break;
                default: break;
            }

            //if (index == 0)         //goood
            //{
            //    DoFalse();}

            if (index == 0) DoTrue(); //bad 陳述區塊內僅有一行程式，使用大括號圈住
            else
                DoFalse();

            //if (DoTrue())  //good
            //{
            //    DoTrue();
            //}
            if (DoTrue() == true) { DoTrue(); } //bad 前置大括號〝{〞與後置大括號〝}〞皆單獨置於一行。 在條件陳述式中，不將布林變數與true/false作比較

            return (index * (index + 1) / 2);   //bad 回傳值本身不再使用括號 大括號結尾後需間隔一行
            /*return index * (index + 1) / 2;*/ //good 
        }

        
        /// <summary>
        /// 回傳True
        /// </summary>
        /// <returns></returns>
        private bool DoTrue() // 每個方法或類別之間需間隔一行
        {
            return true;
        }
        
        /// <summary>
        /// 回傳false
        /// </summary>
        /// <returns></returns>
        private bool DoFalse() // 每個方法或類別之間需間隔一行
        {
            return false;
        }

        /// <summary>
        /// 字串處理
        /// </summary>
        /// <param name="value">The value.</param>
        public void TestStringFunction(string value)
        {
            string NewString = "ABCDEFG"; // bad新字串
            /*string newString = "ABCDEFG";*/ // good 變數命名字首要小寫

            // bad
            //if (value != null | value != "") value = NewString.Replace("A", ",").Replace("B", "_").Replace("C", " ");

            // good
            if (!string.IsNullOrWhiteSpace(value))
                 new StringBuilder(NewString).Replace("A", ",").Replace("B","_").Replace("C"," ").ToString();
        }



    }
}