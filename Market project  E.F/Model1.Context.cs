//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Market_project__E.F
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class marketEntities1 : DbContext
    {
        public marketEntities1()
            : base("name=marketEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<Export_permession> Export_permession { get; set; }
        public virtual DbSet<Export_Quantity> Export_Quantity { get; set; }
        public virtual DbSet<import_permession> import_permession { get; set; }
        public virtual DbSet<Import_Quantity> Import_Quantity { get; set; }
        public virtual DbSet<Item_store> Item_store { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<measuring_unit> measuring_unit { get; set; }
        public virtual DbSet<store> stores { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
    
        public virtual int impdate(Nullable<int> iD, Nullable<int> perNo, Nullable<int> itmId, string mail, string strName, Nullable<int> q)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var perNoParameter = perNo.HasValue ?
                new ObjectParameter("perNo", perNo) :
                new ObjectParameter("perNo", typeof(int));
    
            var itmIdParameter = itmId.HasValue ?
                new ObjectParameter("itmId", itmId) :
                new ObjectParameter("itmId", typeof(int));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var strNameParameter = strName != null ?
                new ObjectParameter("StrName", strName) :
                new ObjectParameter("StrName", typeof(string));
    
            var qParameter = q.HasValue ?
                new ObjectParameter("Q", q) :
                new ObjectParameter("Q", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("impdate", iDParameter, perNoParameter, itmIdParameter, mailParameter, strNameParameter, qParameter);
        }
    
        public virtual int impQ_update(Nullable<int> iD, Nullable<int> itmId1, string mail1, string strName1, Nullable<int> q)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var itmId1Parameter = itmId1.HasValue ?
                new ObjectParameter("itmId1", itmId1) :
                new ObjectParameter("itmId1", typeof(int));
    
            var mail1Parameter = mail1 != null ?
                new ObjectParameter("mail1", mail1) :
                new ObjectParameter("mail1", typeof(string));
    
            var strName1Parameter = strName1 != null ?
                new ObjectParameter("StrName1", strName1) :
                new ObjectParameter("StrName1", typeof(string));
    
            var qParameter = q.HasValue ?
                new ObjectParameter("Q", q) :
                new ObjectParameter("Q", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("impQ_update", iDParameter, itmId1Parameter, mail1Parameter, strName1Parameter, qParameter);
        }
    
        public virtual int expQuant(Nullable<int> exID, Nullable<int> experNo, Nullable<int> exitmId, string cmail, string exStrName, Nullable<int> exQ)
        {
            var exIDParameter = exID.HasValue ?
                new ObjectParameter("exID", exID) :
                new ObjectParameter("exID", typeof(int));
    
            var experNoParameter = experNo.HasValue ?
                new ObjectParameter("experNo", experNo) :
                new ObjectParameter("experNo", typeof(int));
    
            var exitmIdParameter = exitmId.HasValue ?
                new ObjectParameter("exitmId", exitmId) :
                new ObjectParameter("exitmId", typeof(int));
    
            var cmailParameter = cmail != null ?
                new ObjectParameter("cmail", cmail) :
                new ObjectParameter("cmail", typeof(string));
    
            var exStrNameParameter = exStrName != null ?
                new ObjectParameter("exStrName", exStrName) :
                new ObjectParameter("exStrName", typeof(string));
    
            var exQParameter = exQ.HasValue ?
                new ObjectParameter("exQ", exQ) :
                new ObjectParameter("exQ", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("expQuant", exIDParameter, experNoParameter, exitmIdParameter, cmailParameter, exStrNameParameter, exQParameter);
        }
    
        public virtual int MiniusImpQun_(Nullable<int> newQ, Nullable<int> item_id, string storename)
        {
            var newQParameter = newQ.HasValue ?
                new ObjectParameter("newQ", newQ) :
                new ObjectParameter("newQ", typeof(int));
    
            var item_idParameter = item_id.HasValue ?
                new ObjectParameter("item_id", item_id) :
                new ObjectParameter("item_id", typeof(int));
    
            var storenameParameter = storename != null ?
                new ObjectParameter("storename", storename) :
                new ObjectParameter("storename", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MiniusImpQun_", newQParameter, item_idParameter, storenameParameter);
        }
    
        public virtual int expQ_update(Nullable<int> itemID, Nullable<int> pernumber, string uc_mail1, string uStrName1, Nullable<int> uQ)
        {
            var itemIDParameter = itemID.HasValue ?
                new ObjectParameter("itemID", itemID) :
                new ObjectParameter("itemID", typeof(int));
    
            var pernumberParameter = pernumber.HasValue ?
                new ObjectParameter("pernumber", pernumber) :
                new ObjectParameter("pernumber", typeof(int));
    
            var uc_mail1Parameter = uc_mail1 != null ?
                new ObjectParameter("uc_mail1", uc_mail1) :
                new ObjectParameter("uc_mail1", typeof(string));
    
            var uStrName1Parameter = uStrName1 != null ?
                new ObjectParameter("UStrName1", uStrName1) :
                new ObjectParameter("UStrName1", typeof(string));
    
            var uQParameter = uQ.HasValue ?
                new ObjectParameter("UQ", uQ) :
                new ObjectParameter("UQ", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("expQ_update", itemIDParameter, pernumberParameter, uc_mail1Parameter, uStrName1Parameter, uQParameter);
        }
    
        public virtual int Up_itemstorQ(Nullable<int> itemID, string st_nm, Nullable<int> newQun)
        {
            var itemIDParameter = itemID.HasValue ?
                new ObjectParameter("itemID", itemID) :
                new ObjectParameter("itemID", typeof(int));
    
            var st_nmParameter = st_nm != null ?
                new ObjectParameter("St_nm", st_nm) :
                new ObjectParameter("St_nm", typeof(string));
    
            var newQunParameter = newQun.HasValue ?
                new ObjectParameter("NewQun", newQun) :
                new ObjectParameter("NewQun", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Up_itemstorQ", itemIDParameter, st_nmParameter, newQunParameter);
        }
    
        public virtual ObjectResult<storeReport_Result> storeReport(string stName)
        {
            var stNameParameter = stName != null ?
                new ObjectParameter("stName", stName) :
                new ObjectParameter("stName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<storeReport_Result>("storeReport", stNameParameter);
        }
    
        public virtual ObjectResult<itemreport_Result> itemreport(Nullable<int> item_ID, string stname)
        {
            var item_IDParameter = item_ID.HasValue ?
                new ObjectParameter("item_ID", item_ID) :
                new ObjectParameter("item_ID", typeof(int));
    
            var stnameParameter = stname != null ?
                new ObjectParameter("stname", stname) :
                new ObjectParameter("stname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<itemreport_Result>("itemreport", item_IDParameter, stnameParameter);
        }
    
        public virtual ObjectResult<itemperiod_Result> itemperiod(Nullable<int> itmId, Nullable<int> rang)
        {
            var itmIdParameter = itmId.HasValue ?
                new ObjectParameter("itmId", itmId) :
                new ObjectParameter("itmId", typeof(int));
    
            var rangParameter = rang.HasValue ?
                new ObjectParameter("Rang", rang) :
                new ObjectParameter("Rang", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<itemperiod_Result>("itemperiod", itmIdParameter, rangParameter);
        }
    
        public virtual int updatetrans(Nullable<int> itmid, Nullable<System.DateTime> prodate, Nullable<System.DateTime> exdate, string stname)
        {
            var itmidParameter = itmid.HasValue ?
                new ObjectParameter("itmid", itmid) :
                new ObjectParameter("itmid", typeof(int));
    
            var prodateParameter = prodate.HasValue ?
                new ObjectParameter("prodate", prodate) :
                new ObjectParameter("prodate", typeof(System.DateTime));
    
            var exdateParameter = exdate.HasValue ?
                new ObjectParameter("exdate", exdate) :
                new ObjectParameter("exdate", typeof(System.DateTime));
    
            var stnameParameter = stname != null ?
                new ObjectParameter("stname", stname) :
                new ObjectParameter("stname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatetrans", itmidParameter, prodateParameter, exdateParameter, stnameParameter);
        }
    
        public virtual ObjectResult<expdate_Result> expdate(Nullable<int> itmcod, Nullable<int> day)
        {
            var itmcodParameter = itmcod.HasValue ?
                new ObjectParameter("itmcod", itmcod) :
                new ObjectParameter("itmcod", typeof(int));
    
            var dayParameter = day.HasValue ?
                new ObjectParameter("day", day) :
                new ObjectParameter("day", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<expdate_Result>("expdate", itmcodParameter, dayParameter);
        }
    }
}
