using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace FoodCMU.Module.BusinessObjects.FoodShop
{

    public partial class HoaDon
    {
        public HoaDon(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
