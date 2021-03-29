﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier qui represente la table 'responsable' de la base de données.
    /// </summary>
    public class Responsable
    {
        private string login;
        private string pwd;

        /// <summary>
        /// Constructeur, valorise les propriétés.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }

        public string Login { get => login; }
        public string Pwd { get => pwd; }
    }
}
