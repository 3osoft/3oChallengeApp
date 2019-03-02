using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _3oChallengeDomain
{
    public static class DomainObjectFactory<DB, DOMAIN> 
        where DB : class 
        where DOMAIN : class
    {
        public static DOMAIN Create(DB dbObject, Func<DOMAIN> domainConst)
        {
            DOMAIN domainObject = domainConst();

            PropertyInfo[] srcFields = GetPropertyInfoFromClass(dbObject);
            PropertyInfo[] destFields = GetPropertyInfoFromClass(domainObject);
            
            foreach (var property in srcFields)
            {
                var dest = destFields.FirstOrDefault(x => x.Name == property.Name);
                if(dest != null && dest.CanWrite)
                    dest.SetValue(domainObject, property.GetValue(dbObject, null), null);
            }
            return domainObject;
        }

        private static PropertyInfo[] GetPropertyInfoFromClass(Object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty);
            return properties;
        }
    }
}
