using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsp.Domain.Common
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreateDate = DateOnly.FromDateTime(DateTime.Now);
            CreateTime = TimeOnly.FromDateTime(DateTime.Now);
        }
        public Guid Id { get; set; }
        public DateOnly CreateDate { get; set; }
        public TimeOnly CreateTime { get; set; }
        public DateOnly? UpdateDate { get; set; }
        public TimeOnly? UpdateTime { get; set; }
        public DateOnly? DeleteDate { get; set; }
        public TimeOnly? DeleteTime { get; set; }
    }    
}
