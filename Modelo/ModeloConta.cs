using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloConta
    {
        public ModeloConta()
        {
            this.ContaId = 0;
            this.UserName = "";
            this.UserPW = "";
            this.UserEmail = "";
            this.UserNasc = DateTime.MinValue;
            this.ContaStatus = true;
        }

        public ModeloConta(int codigo, string nome, string pw, string email, DateTime nasc, bool statu)
        {
            this.ContaId = codigo;
            this.UserName = nome;
            this.UserPW = pw;
            this.UserEmail = email;
            this.UserNasc = nasc;
            this.ContaStatus = statu;
        }
        private int conta_id;

        public int ContaId
        {
            get { return this.conta_id; }
            set { this.conta_id = value; }
        }
        private string user_name;
        public string UserName
        {
            get { return this.user_name; }
            set { this.user_name = value; }
        }
        private string user_pw;
        public string UserPW
        {
            get { return this.user_pw; }
            set { this.user_pw = value; }
        }
        private string user_email;
        public string UserEmail
        {
            get { return this.user_email; }
            set { this.user_email = value; }
        }
        private DateTime user_nasc;
        public DateTime UserNasc
        {
            get { return this.user_nasc; }
            set { this.user_nasc = value; }
        }
        private bool conta_status;
        public bool ContaStatus
        {
            get { return this.conta_status; }
            set { this.conta_status = value; }
        }
    }
}
