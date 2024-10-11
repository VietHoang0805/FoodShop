using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace FoodCMU.Module.BusinessObjects.FoodCMU
{

    public partial class Mon
    {
        public Mon(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
