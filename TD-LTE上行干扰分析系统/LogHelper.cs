using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Threading;

namespace TD_LTE上行干扰分析系统
{
    class LogHelper
    {
        private volatile static LogHelper m_instance = null;
        private static readonly object lockHelper = new object();
        private string fileName = string.Empty;
        private string path = "log00";
        private FileStream fs = null;
        private Stopwatch stopWatch = null;
        private Stopwatch logWatch = null;

        private LogHelper() {
            stopWatch = new Stopwatch();
            stopWatch.Start();
            logWatch = new Stopwatch();
            logWatch.Start();
            init_file_name();
        }

        public static LogHelper instance()
        {
            if (m_instance == null) {
                lock(lockHelper) {
                    if (m_instance == null) {
                        m_instance = new LogHelper();
                    }
                }
            }
            return m_instance;
        }

        private bool is_to_bigger()
        {
            return (fs != null && fs.Length >= 1024 * 10);
        }

        private void init_file_stream() {
            if (stopWatch.Elapsed.Seconds >= 60 || is_to_bigger()) {
                if (is_to_bigger()) {
                    fs.Close();
                    fs = null;
                } else {
                    //stopWatch.Restart();
                    stopWatch.Reset();
                    stopWatch.Start();
                }
                init_file_name();
            }
            if (fs == null) {
                fs = new FileStream(fileName,
                                    FileMode.OpenOrCreate,
                                    FileAccess.ReadWrite,
                                    FileShare.None,
                                    4096,
                                    true);
            }
        }
        private void init_file_name()
        {
            int subFix = 0;
            DateTime dt = DateTime.Now;
            path = "log\\" + dt.ToString("yyyyMMddHH");
            if (!Directory.Exists(path)) {
                subFix = Directory.CreateDirectory(path).GetFiles().Length;
            } else {
                subFix = Directory.GetFiles(path).Length;
            }

            fileName = path + "\\" + dt.ToString("yyyyMMddHHmm-") + subFix.ToString() + ".txt";
        }

        private string get_cur_time() { return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss "); }

        private bool is_time_out(int _time = 500)
        {
            bool rt = false;

            if(_time == 50)
                return true;

            if(logWatch.Elapsed.Milliseconds > _time || !logWatch.IsRunning)
            {
                //logWatch.Restart();
                logWatch.Reset();
                logWatch.Start();
                rt = true;
            }

            return rt;
        }

        public bool write(string text, int _time = 500)
        {
            try {
                if(_time > 0 && !is_time_out(_time))
                    return false;

                string tm = get_cur_time();
                init_file_stream();
                if (fs != null) {
                    System.Console.WriteLine(tm + text);
                    byte[] info = new UTF8Encoding(true).GetBytes(tm + text + "\r\n");
                    fs.Write(info, 0, info.Length);
                    fs.Flush();
                    return true;
                } 
            } catch (System.Exception ex) {
                Console.WriteLine("### error.");
                Console.WriteLine("###"+ex.Message);
            }
            return false;
        }
    }
}
