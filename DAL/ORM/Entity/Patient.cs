﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ORM.Entity
{
    public class Patient : BaseEntity
    {
        public int RecordNo { get; set; }

        public string Surname { get; set; }

        [MaxLength(120)]
        public string Address { get; set; }

        public byte Gender { get; set; }

        [StringLength(11)]
        public string HomePhone { get; set; }

        [StringLength(11)]
        public string MobilePhone { get; set; }

        [StringLength(11)]
        public string TcNo { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BirthDate { get; set; }

        public string PlaceOfBirth { get; set; }
       
        [ForeignKey("Policlinic")]
        public int PoliclinicId { get; set; }
        public virtual Policlinic Policlinic { get; set; }

        [ForeignKey("City")]
        public int BirthCityId { get; set; }
        public virtual City City { get; set; }

        [ForeignKey("Town")]
        public int BirthTownId { get; set; }
        public virtual Town Town { get; set; }
    }
}
