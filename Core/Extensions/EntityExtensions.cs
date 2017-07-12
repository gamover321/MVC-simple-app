//#region References

//using System;
//using System.Collections.Generic;
//using System.Data.Entity.Core.Objects.DataClasses;

//using System.Globalization;
//using System.Linq;
//using System.Reflection;
//using System.Web;

//using EntityClasses;

//#endregion

//namespace Core
//{
//    public static class EntityExtensions
//    {
//        public static bool Save(this DbSe element, TestProjectEntities ec)
//        {
//           if (element.EntityKey == null)
//            {
//                ec.AddObject(element.GetType().Name, element);
//                element.LogChanges(true);
//            }
//            else
//            {
//                object originalItem;
//                if (ec.TryGetObjectByKey(element.EntityKey, out originalItem))
//                {
//                    element.LogChanges(false, originalItem);
//                    ec.ApplyCurrentValues(element.EntityKey.EntitySetName, element);
//                }
//            }

//            return true;
//        }

//        public static bool Delete(this EntityObject element, TestProjectEntities1 ec)
//        {         

          
//            ec.Remo(element);

//            return true;
//        }

//        public static bool SaveChanges(TestProjectEntities1 ec)
//        {
//           try
//            {
//                ec.SaveChanges();
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }
        
      
//    }
//}