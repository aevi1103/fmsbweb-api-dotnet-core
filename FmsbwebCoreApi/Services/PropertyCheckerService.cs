using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Services
{
    public class PropertyCheckerService : IPropertyCheckerService
    {
        public bool TypeHasProperties<T>(string fields)
        {
            if (string.IsNullOrWhiteSpace(fields))
            {
                return true;
            }

            // the field are separated by ",", so we split it.
            var fieldsAfterSplit = fields.Split(',');

            // check if the requested fields exist on source
            return fieldsAfterSplit.Select(field => 
                field.Trim()).Select(propertyName => 
                typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance)).All(propertyInfo => propertyInfo != null);

            // all checks out, return true
        }
    }
}
