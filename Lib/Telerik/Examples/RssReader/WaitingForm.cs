using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Threading;

namespace RssReader
{
    public partial class WaitingForm : RadForm
    {
        private static Thread waitingThread;
        private static WaitingForm waitingForm;
        
        public WaitingForm()
        {
            InitializeComponent();
            this.radWaitingBar1.StartWaiting();
        }
 
        public static void ShowForm(Form owner) 
        {
            waitingThread = new Thread(new ParameterizedThreadStart(ThreadTask)); 
            waitingThread.IsBackground = false;
            waitingThread.Start(owner);
        } 
 
        private static void ThreadTask(object owner) 
        {
            //initialize the form
            waitingForm = new WaitingForm();
            waitingForm.ShowInTaskbar = false;
            waitingForm.Owner = (Form)owner;
            waitingForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            waitingForm.ControlBox = false;
            waitingForm.TopMost = true;
            waitingForm.StartPosition = FormStartPosition.CenterScreen;            
            Application.Run(waitingForm); 
        }

        public static void CloseDialogDown()
        {
            Application.ExitThread();
        }

        public static void CloseForm() 
        {
            try
            {
                while (waitingForm == null || !waitingForm.IsHandleCreated)
                {
                    Thread.Sleep(10);
                }
                MethodInvoker mi = new MethodInvoker(CloseDialogDown);
                waitingForm.Invoke(mi);
            }
            catch { }
        }
    }
}
