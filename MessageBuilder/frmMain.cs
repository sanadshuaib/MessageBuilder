using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

namespace MessageBuilder
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            FileChecker.filepath = @"d:/messages.json";
        }

        IMessageReader reader;
        IMessageWriter writer;
        List<MessageHandler> _public_list;
        string _filepath = "";

        void ReadMessages()
        {
            cboMessageType.DataSource = Enum.GetValues(typeof(MessageTypes));
            messageTypeDataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(MessageTypes));
            
            reader = new MessageReader();
            _public_list = reader.ReadMessages();
            dgMessages.DataSource = _public_list;
        }

        void WriteMessages()
        {
            MessageTypes mType;
            Enum.TryParse<MessageTypes>(cboMessageType.SelectedValue.ToString(), out mType);

            MessageHandler message = new MessageHandler()
            {
                MessageCode = txtMessageCode.Text,
                MessageTitle = txtMessageTitle.Text,
                MessageBody = txtMessageBody.Text,
                MessageType = mType
            };

            writer = new MessageWriter(message, reader.ReadMessages());
            writer.WriteMessages();
            ReadMessages();

            txtMessageCode.Text = "";
            txtMessageTitle.Text = "";
            txtMessageBody.Text = "";
            cboMessageType.SelectedIndex = 0;
        }

        void WriteAllMessages()
        {
            List<MessageHandler> messages = new List<MessageHandler>();
            MessageTypes mType;

            foreach (DataGridViewRow row in dgMessages.Rows)
            {
                if (!row.IsNewRow &&
                    !string.IsNullOrEmpty(row.Cells[0].Value + ""))
                {
                    if (row.Cells["messageTypeDataGridViewTextBoxColumn"].Value is null)
                    {
                        mType = MessageTypes.NORMAL;
                    }
                    else
                        Enum.TryParse<MessageTypes>(row.Cells["messageTypeDataGridViewTextBoxColumn"].Value.ToString(), out mType);

                    messages.Add(new MessageHandler
                    {
                        MessageCode = row.Cells[0].Value + "",
                        MessageTitle = row.Cells[1].Value + "",
                        MessageBody = row.Cells[2].Value + "",
                        MessageType = mType
                    });
                }
            }

            writer = new MessageWriter(messages);
            writer.WriteMessagesAtOnce();
            ReadMessages();
        }

        bool ValidMessageData()
        {
            if (TextChecker.TextIsEmpty(txtMessageCode))
                return false;
            if (TextChecker.TextIsEmpty(txtMessageTitle))
                return false;
            if (TextChecker.TextIsEmpty(txtMessageBody))
                return false;
            return true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidMessageData())
            {
                WriteMessages();
            }
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ReadMessages();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            WriteAllMessages();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReadMessages();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(dg == DialogResult.Yes && 
                _public_list.Count>0)
            {
                _public_list.RemoveAt(dgMessages.CurrentRow.Index);
                dgMessages.DataSource = _public_list;
                btnSaveAll_Click(sender, e);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            browser.ShowDialog();
            _filepath = browser.SelectedPath;
            FileChecker.filepath = _filepath+"\\messages.json";
        }
    }
}
