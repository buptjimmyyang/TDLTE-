using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace TD_LTE上行干扰分析系统
{
    class XMLHelper
    {
        private XmlDocument xmlDoc = null;
        private volatile static XMLHelper m_instance = null;
        private static readonly object lockHelper = new object();

        private XMLHelper()
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load("ImportDataConfigure.xml");
        }

        public static XMLHelper instatnce()
        {
            if (m_instance == null) {
                lock(lockHelper) {
                    if (m_instance == null) {
                        m_instance = new XMLHelper();
                    }
                }
            }
            return m_instance;
        }


       

        /*
         * 读取sql命令
         */
        public bool getSqlCommand(String nodePath, ref String sqlCommand)
        {
            try
            {
                sqlCommand = xmlDoc.SelectSingleNode(nodePath).FirstChild.InnerText;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            if (sqlCommand.Equals(""))
            {
                Console.WriteLine("xml文件中该语句为空！");
                return false;
            }

            return true;
        }



    }
}
