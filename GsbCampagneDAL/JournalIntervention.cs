//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GsbCampagneDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class JournalIntervention
    {
        public int Id { get; set; }
        public string NomTable { get; set; }
        public string OperationEffetctue { get; set; }
        public System.DateTime DateHeure { get; set; }
        public string ReferenceEnregistrement { get; set; }
        public int IdSalarie { get; set; }
    
        public virtual Salarie Salarie { get; set; }
    }
}
