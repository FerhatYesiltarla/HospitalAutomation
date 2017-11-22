﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ORM.Entity
{
    public class Staff : BaseEntity
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

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BirthDate { get; set; }

        public string PlaceOfBirth { get; set; }

        [ForeignKey("Title")]
        public int TitleId { get; set; }
        public virtual Title Title { get; set; }

        [ForeignKey("Policlinic")]
        public int PoliclinicId { get; set; }
        public virtual Policlinic Policlinic { get; set; }

        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
