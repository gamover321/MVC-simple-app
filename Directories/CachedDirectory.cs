#region References

using System.Collections.Generic;
using System.Linq;


#endregion

namespace Directories
{
   public abstract class CachedDirectory<TCachedDirectory> : NonCachedDirectory<TCachedDirectory> where TCachedDirectory : CachedDirectory<TCachedDirectory>, new()
    {
        #region Cache

        // Property to store cache data
        protected static IEnumerable<TCachedDirectory> Cached { get; set; }

        // Property to use data
        protected static IEnumerable<TCachedDirectory> AllDirectory
        {
            get { return Cached ?? (Cached = GetAllNonCache(new TCachedDirectory())); }
        }


        public new static IEnumerable<TCachedDirectory> GetAll()
        {
            return AllDirectory.ToList();
        }

        public static TCachedDirectory GetById(int id)
        {
            return AllDirectory.FirstOrDefault(item => item.ID == id);
        }
        #endregion     


        public static void ClearCache()
        {
            Cached = null;
        }
    }
   
}
