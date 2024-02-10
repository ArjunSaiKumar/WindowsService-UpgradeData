using System;
using System.IO;
using System.ServiceProcess;
using System.Timers;

namespace UpgradeData
{
    partial class UpgradeService : ServiceBase
    {
        string _connectionstring = "";
        int timeinterval = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["TimerElapsedLimit"]);

        Timer timer = new Timer();
        public UpgradeService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = timeinterval;
            timer.Enabled = true;
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            Log("Service satarted");
            ThingsToDo();
            Log("Service work completed");
        }

        protected override void OnStop()
        {
            Log("Service stoped");
        }

        public void ThingsToDo()
        {
            Log("Operation initiated");
            try
            {
                Log("Operation completed");
            }
            catch (Exception ex)
            {
                Log($"Exception: {ex.Message}");
                throw;
            }
        }

        public void Log(string content)
        {
            string fileName = $"Log_{DateTime.Now:yyyy-MM-dd}.txt";
            FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(" ");
            sw.WriteLine($"{DateTime.Now} : {content}");
            sw.Flush();
            //close the writer
            sw.Close();
        }
    }
}
