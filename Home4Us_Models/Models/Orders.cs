using Home4Us_Models.Models;

namespace Home4Us_Models
{
  public  class Orders : BaseClassID
    {
        public int PropertyId { get; set; }

        public int UserId { get; set; }

        public virtual Property Property { get; set; }

        public virtual Users Users { get; set; }
    }
}
