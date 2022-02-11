
using componentModel = System.ComponentModel;

namespace ACM.BusinessLayer
{
    public enum EntityStateOption
    {
        [componentModel.Description("Active")]
        Active,
        [componentModel.Description("Disabled")]
        Deleted
    }
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid { get => Validate(); }
        public abstract bool Validate();
    }
}
