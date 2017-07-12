
using System.Collections.Generic;

using System.Linq;

using EntityClasses;


namespace Directories.Language
{
    public class Language : CachedDirectory<Language>
    {


        protected override IEnumerable<Language> MassClone(TestProjectEntities1 ec)
        {
            var result = new List<Language>();
            var list = ec.tb_language.Select(item =>
                                                        new Language
                                                        {
                                                            ID = item.id,
                                                            Name = item.name
                                                        }).ToList();
            result.AddRange(list);
            return result;
        }




    }
}
