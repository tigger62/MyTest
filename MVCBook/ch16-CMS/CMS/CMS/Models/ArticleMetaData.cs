﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CMS.Models
{
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(ArticleMetaData))]
    public partial class Article
    {
        public class ArticleMetaData
        {
            public System.Guid ID { get; set; }
            [DisplayName("主題")]
            public string Subject { get; set; }
            [DisplayName("簡介")]
            public string Summary { get; set; }
            [DisplayName("內容")]
            public string ContentText { get; set; }
            [DisplayName("是否發佈")]
            public bool IsPublich { get; set; }
            [DisplayName("發佈日期")]
            public System.DateTime PublishDate { get; set; }
            [DisplayName("瀏灠次數")]
            public int ViewCount { get; set; }
            [DisplayName("建立者")]
            public System.Guid CreateUser { get; set; }
            [DisplayName("建立時間")]
            public System.DateTime CreateDate { get; set; }
            [DisplayName("修改者")]
            public Nullable<System.Guid> UpdateUser { get; set; }
            [DisplayName("修改時間")]
            public System.DateTime UpdateDate { get; set; }
        }
    }

}