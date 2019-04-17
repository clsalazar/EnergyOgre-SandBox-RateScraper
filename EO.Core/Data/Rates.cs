//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EO.Core.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rates
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rates()
        {
            //this.Documents = new HashSet<Documents>();
            //this.Contracts = new HashSet<Contracts>();
            //this.PriceQuantityPairs = new HashSet<PriceQuantityPairs>();
            //this.BillForecasts = new HashSet<BillForecasts>();
            //this.RatesEFL = new HashSet<RatesEFL>();
            //this.SavingsEstimates = new HashSet<SavingsEstimates>();
        }
    
        public int RateId { get; set; }
        public Nullable<int> PreviousRateId { get; set; }
        public int RateSourceId { get; set; }
        public int SourceIdentifier { get; set; }
        public int RateTypeId { get; set; }
        public Nullable<int> RateStructureId { get; set; }
        public int PremiseTypeId { get; set; }
        public int TDSPId { get; set; }
        public Nullable<int> TDSPRateBatchId { get; set; }
        public int REPId { get; set; }
        public string Product { get; set; }
        public decimal kwh500 { get; set; }
        public decimal kwh1000 { get; set; }
        public decimal kwh2000 { get; set; }
        public string FeesCredits { get; set; }
        public bool PrePaid { get; set; }
        public bool TimeOfUse { get; set; }
        public Nullable<decimal> Renewable { get; set; }
        public Nullable<int> TermValue { get; set; }
        public string CancelFee { get; set; }
        public string Website { get; set; }
        public string SpecialTerms { get; set; }
        public Nullable<int> TOSDocumentId { get; set; }
        public Nullable<int> EFLDocumentId { get; set; }
        public Nullable<int> YRACDocumentId { get; set; }
        public string TermsURL { get; set; }
        public string FactsURL { get; set; }
        public string RightsURL { get; set; }
        public bool Promotion { get; set; }
        public string PromotionDesc { get; set; }
        public string EnrollURL { get; set; }
        public string PrepaidURL { get; set; }
        public string EnrollPhone { get; set; }
        public Nullable<bool> TopPick { get; set; }
        public Nullable<decimal> MinimumUsageCharge { get; set; }
        public bool AutoDebitRequired { get; set; }
        public bool ConsiderForPredictions { get; set; }
        public System.DateTime ActiveTime { get; set; }
        public System.DateTime InactiveTime { get; set; }
        public Nullable<System.DateTime> ApprovalTime { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> RejectionTime { get; set; }
        public string RejectedBy { get; set; }
        public Nullable<System.DateTime> DeleteTime { get; set; }
        public Nullable<System.DateTime> LastModifiedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> RateCurveGeneratedTime { get; set; }
    
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Documents> Documents { get; set; }
        //public virtual REP REP { get; set; }
        //public virtual TDSP TDSP { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Contracts> Contracts { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PriceQuantityPairs> PriceQuantityPairs { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BillForecasts> BillForecasts { get; set; }
        //public virtual RateSource RateSource { get; set; }
        //public virtual RateStructure RateStructure { get; set; }
        //public virtual RateType RateType { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<RatesEFL> RatesEFL { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SavingsEstimates> SavingsEstimates { get; set; }
    }
}
