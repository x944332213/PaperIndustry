﻿using System;
using System.Data.Sql.Table;
using System.Data.Sql.Table.Attribute;

namespace Lvshi.PaperProducts.Model.Table
{
    [Serializable]
    public class ModelArticle
    {
        [TableFieldInfo(Lable = TableFieldLable.Identity | TableFieldLable.PrimaryKey)]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Intro { get; set; }

        public string EffectPicture { get; set; }

        public int TypeId { get; set; }

        public string Url { get; set; }

        public EnumCharacter.Value Character { get; set; }

        public int Rank { get; set; }

        public EnumStatus.Value Status { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime ChangeTime { get; set; }
    }

    public static class ModelArticleExtension
    {
        public static string Url(this ModelArticle model)
        {
            if (model == null)
            {
                return string.Empty;
            }
            if (!string.IsNullOrEmpty(model.Url))
            {
                return model.Url;
            }
            if (model.Id > 0)
            {
                return $"/article/{model.Id}";
            }
            return string.Empty;
        }
    }
}
