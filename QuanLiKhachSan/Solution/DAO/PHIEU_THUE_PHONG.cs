
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DAO
{

using System;
    using System.Collections.Generic;
    
public partial class PHIEU_THUE_PHONG
{

    public PHIEU_THUE_PHONG()
    {

        this.CHI_TIET_PHIEU_THUE = new HashSet<CHI_TIET_PHIEU_THUE>();

    }


    public int MaPhieuThue { get; set; }

    public System.DateTime NgayBatDauThue { get; set; }

    public int MaPhong { get; set; }

    public Nullable<System.DateTime> NgayTraPhongDK { get; set; }



    public virtual ICollection<CHI_TIET_PHIEU_THUE> CHI_TIET_PHIEU_THUE { get; set; }

    public virtual PHONG PHONG { get; set; }

}

}
