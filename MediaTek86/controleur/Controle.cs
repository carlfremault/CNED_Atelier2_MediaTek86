using MediaTek86.dal;
using MediaTek86.modele;
using MediaTek86.vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controleur
{
    /// <summary>
    /// Classe qui gère l'interaction entre les différentes vues et les modèles.
    /// </summary>
    public class Controle
    {
        FrmPersonnel frmPersonnel;

        public Controle()
        {
            frmPersonnel = new FrmPersonnel(this);
            frmPersonnel.ShowDialog();
        }

        public List<Personnel> GetLePersonnel()
        {
            return AccesDonnees.GetLePersonnel();
        }
    }
}
