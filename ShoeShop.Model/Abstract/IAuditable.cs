﻿using System;

namespace ShoeShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        bool Status { get; set; }
    }
}