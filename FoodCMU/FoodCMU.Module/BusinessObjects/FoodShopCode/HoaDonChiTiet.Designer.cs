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

    public partial class HoaDonChiTiet : DevExpress.Persistent.BaseImpl.BaseObject
    {
        HoaDon fHoaDonID;
        [Association(@"HoaDonChiTietReferencesHoaDon")]
        public HoaDon HoaDonID
        {
            get { return fHoaDonID; }
            set { SetPropertyValue<HoaDon>(nameof(HoaDonID), ref fHoaDonID, value); }
        }
        Mon fMonID;
        [Association(@"HoaDonChiTietReferencesMon")]
        public Mon MonID
        {
            get { return fMonID; }
            set { SetPropertyValue<Mon>(nameof(MonID), ref fMonID, value); }
        }
        int fSoLuong;
        public int SoLuong
        {
            get { return fSoLuong; }
            set { SetPropertyValue<int>(nameof(SoLuong), ref fSoLuong, value); }
        }
        decimal fDonGia;
        public decimal DonGia
        {
            get { return fDonGia; }
            set { SetPropertyValue<decimal>(nameof(DonGia), ref fDonGia, value); }
        }
        [PersistentAlias("ToDecimal([SoLuong]) * [DonGia]")]
        public decimal ThanhTien
        {
            get { return (decimal)(EvaluateAlias(nameof(ThanhTien))); }
        }
    }

}
