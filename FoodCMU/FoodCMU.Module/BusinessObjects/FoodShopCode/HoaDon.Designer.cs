﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace FoodCMU.Module.BusinessObjects.FoodShop
{

    public partial class HoaDon : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fKhachHangID;
        public string KhachHangID
        {
            get { return fKhachHangID; }
            set { SetPropertyValue<string>(nameof(KhachHangID), ref fKhachHangID, value); }
        }
        string fThuNganID;
        public string ThuNganID
        {
            get { return fThuNganID; }
            set { SetPropertyValue<string>(nameof(ThuNganID), ref fThuNganID, value); }
        }
        DateTime fNgay;
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime Ngay
        {
            get { return fNgay; }
            set { SetPropertyValue<DateTime>(nameof(Ngay), ref fNgay, value); }
        }
        int fSoBan;
        public int SoBan
        {
            get { return fSoBan; }
            set { SetPropertyValue<int>(nameof(SoBan), ref fSoBan, value); }
        }
    }

}
