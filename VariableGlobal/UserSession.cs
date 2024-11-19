using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.VariableGlobal
{
    //(transformando a classe em publica para todos utilizarem) e o static eh para todos usarem o mesmo paulo
    public static class UserSession
    {
        //as variaveis vao guardar as informações dos usuarios
        private static string _usuario = null;
        private static string _senha = null;
        private static string _nome = null;

        //encapsulei a variavel para poer ter controle do que ser pego
        public static string usuario 
        { 
            get { return _usuario; }
            set {_usuario = value; }
        }

        public static string nome
        {
            get { return _nome; }
            set
            {_nome = value;}
        }

        public static string senha
        {
            get { return _senha; }
            set
            { _senha = value; }
        }
    }
}
