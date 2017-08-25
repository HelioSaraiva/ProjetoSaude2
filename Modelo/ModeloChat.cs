using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class ModeloChat
    {
        public ModeloChat()
        {
            this.ChatCod = 0;
            this.AmgCod = 0;
            this.ChatMsg = "";
            this.ChatStatus = false;
        }

        public ModeloChat(int chtcod, int amgcod, string chtmsg, Boolean status)
        {
            this.ChatCod = chtcod;
            this.AmgCod = amgcod;
            this.ChatMsg = chtmsg;
            this.ChatStatus = status;
        }
        private int chat_cod;

        public int ChatCod
        {
            get { return this.chat_cod; }
            set { this.chat_cod = value; }
        }
        private int amg_cod;

        public int AmgCod
        {
            get { return this.amg_cod; }
            set { this.amg_cod = value; }
        }
        private string chat_msg;

        public string ChatMsg
        {
            get { return this.chat_msg; }
            set { this.chat_msg = value; }
        }
        private Boolean chat_status;

        public Boolean ChatStatus
        {
            get { return this.chat_status; }
            set { this.chat_status = value; }
        }
        /////////////////
        public void ListarAmigo() { }
        public void EnviaMensagem() { }
    }
}
