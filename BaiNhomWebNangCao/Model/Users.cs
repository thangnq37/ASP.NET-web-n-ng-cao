﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.BaiHoc = new HashSet<BaiHoc>();
            this.BinhLuan = new HashSet<BinhLuan>();
            this.Like = new HashSet<Like>();
        }
    
        public int IdUser { get; set; }
        [Required]
        [Display(Name = "Họ Tên")]
        public string HoTen { get; set; }
        [Required]
        public string Username { get; set; }
        [Display(Name = "Ngày Sinh")]
        public System.DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        [Display(Name = "Giới Tính")]
        public bool GioiTinh { get; set; }
        public int Level { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiHoc> BaiHoc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Like> Like { get; set; }
    }
}
