namespace MarketDemo.Common
{
    public class CommonDate<DT> : Common<DT>
    {
        public DateTime? CreationDate { get; set; }
        public DateTime? LastModifiedDate { get;set; }
    }
}
