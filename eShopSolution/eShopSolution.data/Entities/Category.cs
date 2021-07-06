using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.data.Enum;

namespace eShopSolution.data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int ParentID { set; get; }
        public Status Status { set; get; }
    }
}
