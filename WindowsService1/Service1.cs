using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        Timer recordTimer;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            IntialSaveRecord();
        }

        protected override void OnStop()
        {
            if (recordTimer != null)
            {
                recordTimer.Dispose();
            }
        }


        /// <summary>
        /// 定时检查，并执行方法
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void IntialSaveRecord()
        {
            TimerCallback timerCallback = new TimerCallback(CallbackTask);

            AutoResetEvent autoEvent = new AutoResetEvent(false);
            recordTimer = new Timer(timerCallback, autoEvent, 0, 10000);//其中参数10000表示延时执行服务的时间间隔，毫秒为单位
        }
        //方法
        private void CallbackTask(Object stateInfo)
        {
            Help.SaveRecord(string.Format(@"当前记录时间：{0},状况：程序运行正常！", DateTime.Now));
        }
    }
}
