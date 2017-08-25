using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloUsuario
    {
        public ModeloUsuario()
        {
            this.UserCod = 0;
            this.UserName = "";
            this.UserPW ="";
            this.UserEnd = "";
            this.UserEmail = "";
            this.UserNasc = DateTime.MinValue;
            this.UserSan = "";
            this.UserGen = "";
            this.UserCel = "";
            this.UserDoa = true;
            this.UserAler = "";
            this.UserDiab = "";
            this.UserPress = "";
            this.UserEstCiv = "";
            this.UserProf = "";
            this.UserPeso = 0;
            this.UserAlt = 0;
            this.UserAtFis = true;
            this.UserVicio = "";

        }
        public ModeloUsuario(int cod, string name, string end, string pw, string email, DateTime nascimento, string sanguineo, string celular,
             string genero, Boolean doador, string alergico, string diabetico, string pressao, string estadociv, string profissao, Double peso,
             Double altura, Boolean atifisica, string vicio)
        {
            this.UserCod = cod;
            this.UserName = name;
            this.UserPW = pw;
            this.UserEnd = end;
            this.UserEmail = email;
            this.UserNasc = nascimento;
            this.UserSan = sanguineo;
            this.UserGen = genero;
            this.UserCel = celular;
            this.UserDoa = doador;
            this.UserAler = alergico;
            this.UserDiab = diabetico;
            this.UserPress = pressao;
            this.UserEstCiv = estadociv;
            this.UserProf = profissao;
            this.UserPeso = peso;
            this.UserAlt = altura;
            this.UserAtFis = atifisica;
            this.UserVicio = vicio;
            
        } 
        private int user_cod;

        public int UserCod
        {
            get { return this.user_cod; }
            set { this.user_cod = value; }
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

        private string user_end;
        public string UserEnd
        {
            get { return this.user_end; }
            set { this.user_end = value; }
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
        private string user_san;
        public string UserSan
        {
            get { return this.user_san; }
            set { this.user_san = value; }
        }
        private string user_gen;
        public string UserGen
        {
            get { return this.user_gen; }
            set { this.user_gen = value; }
        }
        private string user_cel;
        public string UserCel
        {
            get { return this.user_cel; }
            set { this.user_cel = value; }
        }
        private Boolean user_doa;
        public Boolean UserDoa
        {
            get { return this.user_doa; }
            set { this.user_doa = value; }
        }
        private string user_aler;
        public string UserAler
        {
            get { return this.user_aler; }
            set { this.user_aler = value; }
        }
        private string user_diab;
        public string UserDiab
        {
            get { return this.user_diab; }
            set { this.user_diab = value; }
        }
        private string user_press;
        public string UserPress
        {
            get { return this.user_press; }
            set { this.user_press = value; }
        }
        private string user_estciv;
        public string UserEstCiv
        {
            get { return this.user_estciv; }
            set { this.user_estciv = value; }
        }
        private string user_prof;
        public string UserProf
        {
            get { return this.user_prof; }
            set { this.user_prof = value; }
        }
        private Double user_peso;
        public Double UserPeso
        {
            get { return this.user_peso; }
            set { this.user_peso = value; }
        }
        private Double user_alt;
        public Double UserAlt
        {
            get { return this.user_alt; }
            set { this.user_alt = value; }
        }
        private Boolean user_atfis;
        public Boolean UserAtFis
        {
            get { return this.user_atfis; }
            set { this.user_atfis = value; }
        }
        private string user_vicio;
        public string UserVicio
        {
            get { return this.user_vicio; }
            set { this.user_vicio = value; }
        }
        ///////////////////////////////////       
        public void EnviarMensagem( string msg)
        {

        }
        public void FazerPost(string post)
        {

        }
        
        public void CalculaIMC(Double peso, Double altura)
        {
            UserPeso = peso;
            UserAlt = altura;
            Double IMC = UserPeso / (UserAlt * UserAlt); 

        }
        public void SeloProf(String Profi) // n é void ,retorna selo
        {
            
        }

    }
}
