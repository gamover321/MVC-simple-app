using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WebApplication2.Models
{
    public class UsersModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }

        public List<SelectListItem> LanguageList { get; set; }
        public int LanguageId { get; set; }
      

       public UsersModel()
        {
            LanguageList = Directories.Language.Language.GetAll().Select(i => new SelectListItem
            {
                Value = i.ID.ToString(),
                Text = i.Name.ToString()
            }).ToList();
        }

        public static List<UsersModel> BuildModel()
        {
            var result = Directories.User.User.GetAll().Select(i => new UsersModel
            {
                Id = i.ID,
                Name = i.Name,
                CreationDate = i.CreationDate,
                LanguageId = i.LanguageId
            }).ToList();

            return result;
        }
        
    }
}