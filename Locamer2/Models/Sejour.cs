//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Locamer2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sejour
    {
        public int id_sejour { get; set; }
        public int id_client { get; set; }
        public int id_typesejour { get; set; }
        public System.DateTime date_debut { get; set; }
        public Nullable<System.DateTime> date_fin { get; set; }
    }
}