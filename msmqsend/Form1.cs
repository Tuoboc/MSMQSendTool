using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Messaging;
using System.Xml;

namespace msmqsend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SEND_Click(object sender, EventArgs e)
        {
            bool ISSHIWU = IS_SHIWU.Checked;
            if (ISSHIWU)
            {
                try
                {
                    MessageQueue mq = new MessageQueue(ADDRESS.Text, false, false, QueueAccessMode.SendAndReceive);
                    MessageQueueTransaction trans = new MessageQueueTransaction();
                    trans.Begin();
                    if (FILEDIR.Text != String.Empty)
                    {
                        XmlDocument xml = new XmlDocument();
                        xml.Load(FILEDIR.Text);
                        System.Messaging.Message ms = new System.Messaging.Message(xml);
                        ms.Formatter = new System.Messaging.XmlMessageFormatter(new Type[] { typeof(XmlDocument) });
                        mq.Send(ms, trans);
                    }
                    if (MESSAGE.Text != String.Empty)
                    {
                        mq.Send(MESSAGE.Text,trans);
                    }
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    MessageQueue mq = new MessageQueue(ADDRESS.Text);
                    if (FILEDIR.Text != String.Empty)
                    {
                        XmlDocument xml = new XmlDocument();
                        xml.Load(FILEDIR.Text);
                        System.Messaging.Message ms = new System.Messaging.Message(xml);
                        ms.Formatter = new System.Messaging.XmlMessageFormatter(new Type[] { typeof(XmlDocument) });
                        ms.Label = "";
                        mq.Send(ms);
                    }
                    if (MESSAGE.Text != String.Empty)
                    {
                        mq.Send(MESSAGE.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
            MessageBox.Show("OK");
        }

        private void SELECTFILE_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FILEDIR.Text = fileDialog.FileName;
            }
        }
    }
}
