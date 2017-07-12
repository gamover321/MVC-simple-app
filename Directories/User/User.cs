using System.Collections.Generic;
using System.Linq;
using EntityClasses;
using System;
using Core;

namespace Directories.User
{


    public class User : NonCachedDirectory<User>
    {

        public DateTime CreationDate { get; set; }
        public int LanguageId { get; set; }

        #region Virtual methods overriding

        protected override IEnumerable<User> MassClone(TestProjectEntities1 ec)
        {
            var result = new List<User>();
            List<User> list = ec.tb_user.Select(item =>
                                                        new User
                                                        {
                                                            ID = item.id,
                                                            Name = item.name,
                                                            CreationDate = item.creation_date,
                                                            LanguageId = item.language_id
                                                        }).ToList();
            result.AddRange(list);
            return result;
        }

        #endregion

        public static bool Add(User user)
        {
            using (var ec = new TestProjectEntities1())
            {
                var tbUser = new tb_user
                {
                    name = user.Name,
                    language_id = user.LanguageId,
                     creation_date= DateTime.Now,
                   
                };
                ec.tb_user.Add(tbUser);
                EntityConnector.SaveChanges(ec);

                return true;
            }
        }

        public static bool Delete(int id)
        {
            using (var ec = new TestProjectEntities1())
            {
                var tbUser = ec.tb_user.FirstOrDefault(i => i.id == id);
                if (tbUser == null)
                {
                    return false;
                }

                ec.tb_user.Remove(tbUser);
                EntityConnector.SaveChanges(ec);

                return true;
            }
        }

    }

}
