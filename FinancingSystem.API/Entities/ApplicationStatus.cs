namespace FinancingSystem.API.Entities
{
    public enum ApplicationStatus
    {
        Pending = 1,          // قيد الانتظار
        Approved = 2,         // مقبول
        Rejected = 3,         // مَرفوض
        RequiresRevision = 4  // مُعاد للعميل للتعديل
    }
}