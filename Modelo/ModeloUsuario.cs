using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloUsuario 
    {

          public ModeloUsuario()
        {
            this.UserId = 0;
         //   this.UserName = "";
            this.UserEnd = "";
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
        public ModeloUsuario(int cod,  string end, string sanguineo, string celular,
             string genero, Boolean doador, string alergico, string diabetico, string pressao, string estadociv, string profissao, Double peso,
             Double altura, Boolean atifisica, string vicio, String pro_foto)
        {
            this.UserId = cod;
    //        this.UserName = name;
            
            this.UserEnd = end;
            

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
            this.CarregaImagem(pro_foto);

        }
        public ModeloUsuario(int cod, string end, string sanguineo, string celular,
             string genero, Boolean doador, string alergico, string diabetico, string pressao, string estadociv, string profissao, Double peso,
             Double altura, Boolean atifisica, string vicio, Byte[] pro_foto)
        {
            this.UserId = cod;
            //        this.UserName = name;

            this.UserEnd = end;


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
            this.UserFoto = pro_foto;

        }
        private int user_id;

        public int UserId
        {
            get { return this.user_id; }
            set { this.user_id = value; }
        }
    /*    private string user_name;
        public string UserName
        {
            get { return this.user_name; }
            set { this.user_name = value; }
        }*/
      

        private string user_end;
        public string UserEnd
        {
            get { return this.user_end; }
            set { this.user_end = value; }
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
        private byte[] _user_foto;
        public byte[] UserFoto
        {
            get { return this._user_foto; }
            set { this._user_foto = value; }
        }
        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedadese métodos de instância para criar, copiar,
                //excluir, mover, e abrir arquivos, e ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte
                //síncrono e assíncrono operações de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória para o vetor
                this.UserFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava osdados em um buffer fornecido.
                int iBytesRead = fs.Read(this.UserFoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


    }
}
